﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using Microsoft.Azure.Commands.Management.Storage.Models;
using Microsoft.Azure.Management.Storage;
using Microsoft.Azure.Management.Storage.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Management.Automation;
using Microsoft.Azure.Management.Internal.Resources.Utilities.Models;

namespace Microsoft.Azure.Commands.Management.Storage
{
    [Cmdlet("New", ResourceManager.Common.AzureRMConstants.AzureRMStoragePrefix + StorageShareNounStr, DefaultParameterSetName = AccountNameParameterSet, SupportsShouldProcess = true), OutputType(typeof(PSShare))]
    public class NewAzureStorageShareCommand : StorageFileBaseCmdlet
    {
        /// <summary>
        /// AccountName Parameter Set
        /// </summary>
        private const string AccountNameParameterSet = "AccountName";

        /// <summary>
        /// Account object parameter set 
        /// </summary>
        private const string AccountObjectParameterSet = "AccountObject";

        [Parameter(
            Position = 0,
            Mandatory = true,
            HelpMessage = "Resource Group Name.",
            ParameterSetName = AccountNameParameterSet)]
        [ValidateNotNullOrEmpty]
        public string ResourceGroupName { get; set; }

        [Parameter(
            Position = 1,
            Mandatory = true,
            HelpMessage = "Storage Account Name.",
            ParameterSetName = AccountNameParameterSet)]
        [Alias(AccountNameAlias)]
        [ValidateNotNullOrEmpty]
        public string StorageAccountName { get; set; }

        [Parameter(Mandatory = true,
            HelpMessage = "Storage account object",
            ValueFromPipeline = true,
            ParameterSetName = AccountObjectParameterSet)]
        [ValidateNotNullOrEmpty]
        public PSStorageAccount StorageAccount { get; set; }

        [Alias("N", "ShareName")]
        [Parameter(Mandatory = true, 
            HelpMessage = "Azure File share name")]
        [ValidateNotNullOrEmpty]
        public string Name { get; set; }

        [Alias("Quota")]
        [Parameter(Mandatory = false,
            HelpMessage = "Share Quota in Gibibyte.")]
        public int QuotaGiB
        {
            get
            {
                return shareQuota is null ? 0 : shareQuota.Value;
            }
            set
            {
                shareQuota = value;
            }
        }
        private int? shareQuota = null;

        [Parameter(HelpMessage = "Share Metadata", Mandatory = false)]
        [AllowEmptyCollection]
        [ValidateNotNull]
        public Hashtable Metadata { get; set; }


        [Parameter(
           Mandatory = false,
           HelpMessage = "Access tier for specific share. StorageV2 account can choose between TransactionOptimized (default), Hot, and Cool. FileStorage account can choose Premium.")]
        [ValidateSet(ShareAccessTier.TransactionOptimized,
            ShareAccessTier.Premium,
            ShareAccessTier.Hot,
            ShareAccessTier.Cool,
           IgnoreCase = true)]
        [ValidateNotNullOrEmpty]
        public string AccessTier
        {
            get
            {
                return accessTier;
            }
            set
            {
                accessTier = value;
            }
        }
        private string accessTier = null;

        [Parameter(Mandatory = false, HelpMessage = "Create a snapshot of existing share with same name.")]
        public SwitchParameter Snapshot { get; set; }
        
        [Parameter(Mandatory = false,
            HelpMessage = "Sets protocols for file shares. It cannot be changed after file share creation. Possible values include: 'SMB', 'NFS'")]
        [ValidateSet(EnabledProtocols.NFS,
            EnabledProtocols.SMB,
            IgnoreCase = true)]
        public string EnabledProtocol { get; set; }

        [Parameter(Mandatory = false,
            HelpMessage = "Sets reduction of the access rights for the remote superuser. Possible values include: 'NoRootSquash', 'RootSquash', 'AllSquash'")]
        [ValidateSet(RootSquashType.NoRootSquash,
            RootSquashType.RootSquash,
            RootSquashType.AllSquash,
            IgnoreCase = true)]
        public string RootSquash { get; set; }

        [Parameter(Mandatory = false,
            HelpMessage = "The provisioned bandwidth of the share, in mebibytes per second. This property is only for file shares created under Files Provisioned v2 account type. Please refer to the Get-AzStorageFileServiceUsage cmdlet output for the minimum and maximum allowed value for provisioned bandwidth.")]
        public int ProvisionedBandwidthMibps
        {
            get
            {
                return provisionedBandwidthMibps is null ? 0 : provisionedBandwidthMibps.Value;
            }
            set
            {
                provisionedBandwidthMibps = value;
            }
        }
        private int? provisionedBandwidthMibps = null;

        [Parameter(Mandatory = false,
            HelpMessage = "The provisioned IOPS of the share. This property is only for file shares created under Files Provisioned v2 account type. Please refer to the Get-AzStorageFileServiceUsage cmdlet output for the minimum and maximum allowed value for provisioned IOPS.")]
        public int ProvisionedIops
        {
            get
            {
                return provisionedIops is null ? 0 : provisionedIops.Value;
            }
            set
            {
                provisionedIops = value;
            }
        }
        private int? provisionedIops = null;

        [Parameter(Mandatory = false,
            HelpMessage = "Indicates whether paid bursting is enabled for the share. This property is only for file shares created under Files Provisioned v1 SSD account type.")]
        public SwitchParameter PaidBurstingEnabled { get; set; }

        [Parameter(Mandatory = false,
            HelpMessage = "The maximum paid bursting IOPS for the share. This property is only for file shares created under Files Provisioned v1 SSD account type. The maximum allowed value is 102400 which is the maximum allowed IOPS for a share.")]
        public int PaidBurstingMaxIops
        {
            get
            {
                return paidBurstingMaxIops is null ? 0 : paidBurstingMaxIops.Value;
            }
            set
            {
                paidBurstingMaxIops = value;
            }
        }
        private int? paidBurstingMaxIops = null;

        [Parameter(Mandatory = false,
            HelpMessage = "The maximum paid bursting bandwidth for the share, in mebibytes per second. This property is only for file shares created under Files Provisioned v1 SSD account type. The maximum allowed value is 10340 which is the maximum allowed bandwidth for a share.")]
        public int PaidBurstingMaxBandwidthMibps
        {
            get
            {
                return paidBurstingMaxBandwidthMibps is null ? 0 : paidBurstingMaxBandwidthMibps.Value;
            }
            set
            {
                paidBurstingMaxBandwidthMibps = value;
            }
        }
        private int? paidBurstingMaxBandwidthMibps = null;

        public override void ExecuteCmdlet()
        {
            base.ExecuteCmdlet();

            if (!string.IsNullOrWhiteSpace(this.RootSquash)
                && ! EnabledProtocols.NFS.Equals(this.EnabledProtocol, StringComparison.OrdinalIgnoreCase))
            {
                throw new ArgumentException("RootSquash should not be specified when EnabledProtocols is not NFS.", "RootSquash");
            }

            if (ShouldProcess(this.Name, "Create share"))
            {
                switch (ParameterSetName)
                {
                    case AccountObjectParameterSet:
                        this.ResourceGroupName = StorageAccount.ResourceGroupName;
                        this.StorageAccountName = StorageAccount.StorageAccountName;
                        break;
                    default:
                        // For AccountNameParameterSet, the ResourceGroupName and StorageAccountName can get from input directly
                        break;
                }

                Dictionary<string, string> MetadataDictionary = CreateMetadataDictionary(Metadata, validate: true);
                string expand = null;
                if (this.Snapshot)
                {
                    expand = ShareCreateExpand.Snapshots;
                }

                FileSharePropertiesFileSharePaidBursting paidBursting = default(FileSharePropertiesFileSharePaidBursting);
                if (this.PaidBurstingEnabled.IsPresent || this.paidBurstingMaxBandwidthMibps != null || this.paidBurstingMaxIops != null)
                {
                    paidBursting = new FileSharePropertiesFileSharePaidBursting(this.PaidBurstingEnabled, this.paidBurstingMaxIops, this.paidBurstingMaxBandwidthMibps);
                }
                var share =
                    this.StorageClient.FileShares.Create(
                            this.ResourceGroupName,
                            this.StorageAccountName,
                            this.Name,
                            new FileShare(
                                metadata: MetadataDictionary,
                                shareQuota: shareQuota,
                                enabledProtocols: this.EnabledProtocol,
                                rootSquash: this.RootSquash,
                                accessTier: accessTier,
                                provisionedIops: this.provisionedIops,
                                provisionedBandwidthMibps: this.provisionedBandwidthMibps,
                                fileSharePaidBursting: paidBursting),
                            expand: expand);

                WriteObject(new PSShare(share));
            }
        }
    }
}
