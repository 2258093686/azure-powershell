// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Extensions;

    /// <summary>Cross Region Restore Request Object</summary>
    public partial class CrossRegionRestoreRequestObject :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.ICrossRegionRestoreRequestObject,
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.ICrossRegionRestoreRequestObjectInternal
    {

        /// <summary>Backing field for <see cref="CrossRegionRestoreDetail" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.ICrossRegionRestoreDetails _crossRegionRestoreDetail;

        /// <summary>Cross region restore details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.ICrossRegionRestoreDetails CrossRegionRestoreDetail { get => (this._crossRegionRestoreDetail = this._crossRegionRestoreDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.CrossRegionRestoreDetails()); set => this._crossRegionRestoreDetail = value; }

        /// <summary>Backing field for <see cref="RestoreRequestObject" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IAzureBackupRestoreRequest _restoreRequestObject;

        /// <summary>Gets or sets the restore request object.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IAzureBackupRestoreRequest RestoreRequestObject { get => (this._restoreRequestObject = this._restoreRequestObject ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.AzureBackupRestoreRequest()); set => this._restoreRequestObject = value; }

        /// <summary>Creates an new <see cref="CrossRegionRestoreRequestObject" /> instance.</summary>
        public CrossRegionRestoreRequestObject()
        {

        }
    }
    /// Cross Region Restore Request Object
    public partial interface ICrossRegionRestoreRequestObject :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.IJsonSerializable
    {
        /// <summary>Cross region restore details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Cross region restore details.",
        SerializedName = @"crossRegionRestoreDetails",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.ICrossRegionRestoreDetails) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.ICrossRegionRestoreDetails CrossRegionRestoreDetail { get; set; }
        /// <summary>Gets or sets the restore request object.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Gets or sets the restore request object.",
        SerializedName = @"restoreRequestObject",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IAzureBackupRestoreRequest) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IAzureBackupRestoreRequest RestoreRequestObject { get; set; }

    }
    /// Cross Region Restore Request Object
    internal partial interface ICrossRegionRestoreRequestObjectInternal

    {
        /// <summary>Cross region restore details.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.ICrossRegionRestoreDetails CrossRegionRestoreDetail { get; set; }
        /// <summary>Gets or sets the restore request object.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IAzureBackupRestoreRequest RestoreRequestObject { get; set; }

    }
}