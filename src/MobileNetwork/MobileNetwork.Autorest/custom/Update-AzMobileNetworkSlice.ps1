
# ----------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# Code generated by Microsoft (R) AutoRest Code Generator.Changes may cause incorrect behavior and will be lost if the code
# is regenerated.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Updates slice.
.Description
Updates slice.
.Example
Update-AzMobileNetworkSlice -MobileNetworkName azps-mn -ResourceGroupName azps_test_group -SliceName azps-mn-slice -Tag @{"abc"="123"} -SnssaiSst 1

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.IMobileNetworkIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ISlice
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IMobileNetworkIdentity>: Identity Parameter
  [AttachedDataNetworkName <String>]: The name of the attached data network.
  [DataNetworkName <String>]: The name of the data network.
  [Id <String>]: Resource identity path
  [MobileNetworkName <String>]: The name of the mobile network.
  [PacketCoreControlPlaneName <String>]: The name of the packet core control plane.
  [PacketCoreDataPlaneName <String>]: The name of the packet core data plane.
  [ResourceGroupName <String>]: The name of the resource group. The name is case insensitive.
  [ServiceName <String>]: The name of the service. You must not use any of the following reserved strings - 'default', 'requested' or 'service'
  [SimGroupName <String>]: The name of the SIM Group.
  [SimName <String>]: The name of the SIM.
  [SimPolicyName <String>]: The name of the SIM policy.
  [SiteName <String>]: The name of the mobile network site.
  [SliceName <String>]: The name of the network slice.
  [SubscriptionId <String>]: The ID of the target subscription.
  [VersionName <String>]: The name of the packet core control plane version.

MOBILENETWORKINPUTOBJECT <IMobileNetworkIdentity>: Identity Parameter
  [AttachedDataNetworkName <String>]: The name of the attached data network.
  [DataNetworkName <String>]: The name of the data network.
  [Id <String>]: Resource identity path
  [MobileNetworkName <String>]: The name of the mobile network.
  [PacketCoreControlPlaneName <String>]: The name of the packet core control plane.
  [PacketCoreDataPlaneName <String>]: The name of the packet core data plane.
  [ResourceGroupName <String>]: The name of the resource group. The name is case insensitive.
  [ServiceName <String>]: The name of the service. You must not use any of the following reserved strings - 'default', 'requested' or 'service'
  [SimGroupName <String>]: The name of the SIM Group.
  [SimName <String>]: The name of the SIM.
  [SimPolicyName <String>]: The name of the SIM policy.
  [SiteName <String>]: The name of the mobile network site.
  [SliceName <String>]: The name of the network slice.
  [SubscriptionId <String>]: The ID of the target subscription.
  [VersionName <String>]: The name of the packet core control plane version.
.Link
https://learn.microsoft.com/powershell/module/az.mobilenetwork/update-azmobilenetworkslice
#>
function Update-AzMobileNetworkSlice {
    [OutputType([Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ISlice])]
    [CmdletBinding(DefaultParameterSetName='UpdateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
    param(
        [Parameter(ParameterSetName='UpdateExpanded', Mandatory)]
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Category('Path')]
        [System.String]
        # The name of the mobile network.
        ${MobileNetworkName},

        [Parameter(ParameterSetName='UpdateExpanded', Mandatory)]
        [Parameter(ParameterSetName='UpdateViaIdentityMobileNetworkExpanded', Mandatory)]
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Category('Path')]
        [System.String]
        # The name of the network slice.
        ${SliceName},

        [Parameter(ParameterSetName='UpdateExpanded', Mandatory)]
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Category('Path')]
        [System.String]
        # The name of the resource group.
        # The name is case insensitive.
        ${ResourceGroupName},
        
        [Parameter(Mandatory)]
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Category('Body')]
        [System.Int32]
        # Slice/service type (SST).
        ${SnssaiSst},

        [Parameter(ParameterSetName='UpdateExpanded')]
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Category('Path')]
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
        [System.String]
        # The ID of the target subscription.
        ${SubscriptionId},

        [Parameter(ParameterSetName='UpdateViaIdentityExpanded', Mandatory, ValueFromPipeline)]
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Category('Path')]
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.IMobileNetworkIdentity]
        # Identity Parameter
        ${InputObject},

        [Parameter(ParameterSetName='UpdateViaIdentityMobileNetworkExpanded', Mandatory, ValueFromPipeline)]
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Category('Path')]
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.IMobileNetworkIdentity]
        # Identity Parameter
        ${MobileNetworkInputObject},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Category('Body')]
        [System.String]
        # An optional description for this network slice.
        ${Description},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Category('Body')]
        [System.String]
        # Slice differentiator (SD).
        ${SnssaiSd},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Category('Body')]
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ITrackedResourceTags]))]
        [System.Collections.Hashtable]
        # Resource tags.
        ${Tag},

        [Parameter()]
        [Alias('AzureRMContext', 'AzureCredential')]
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Category('Azure')]
        [System.Management.Automation.PSObject]
        # The DefaultProfile parameter is not functional.
        # Use the SubscriptionId parameter when available if executing the cmdlet against a different subscription.
        ${DefaultProfile},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Category('Runtime')]
        [System.Management.Automation.SwitchParameter]
        # Run the command as a job
        ${AsJob},

        [Parameter(DontShow)]
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Category('Runtime')]
        [System.Management.Automation.SwitchParameter]
        # Wait for .NET debugger to attach
        ${Break},

        [Parameter(DontShow)]
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Category('Runtime')]
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.SendAsyncStep[]]
        # SendAsync Pipeline Steps to be appended to the front of the pipeline
        ${HttpPipelineAppend},

        [Parameter(DontShow)]
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Category('Runtime')]
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.SendAsyncStep[]]
        # SendAsync Pipeline Steps to be prepended to the front of the pipeline
        ${HttpPipelinePrepend},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Category('Runtime')]
        [System.Management.Automation.SwitchParameter]
        # Run the command asynchronously
        ${NoWait},

        [Parameter(DontShow)]
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Category('Runtime')]
        [System.Uri]
        # The URI for the proxy server to use
        ${Proxy},

        [Parameter(DontShow)]
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Category('Runtime')]
        [System.Management.Automation.PSCredential]
        # Credentials for a proxy server to use for the remote call
        ${ProxyCredential},

        [Parameter(DontShow)]
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Category('Runtime')]
        [System.Management.Automation.SwitchParameter]
        # Use the default credentials for the proxy
        ${ProxyUseDefaultCredentials}
    )

    process {
        try {
            Az.MobileNetwork.internal\UpdateAzMobileNetworkSlice @PSBoundParameters
        } catch {
            
            throw
        }
    }
}
