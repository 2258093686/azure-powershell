// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Extensions;

    /// <summary>The JSON object that contains the properties required to create an endpoint.</summary>
    public partial class AfdEndpointProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdEndpointProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdEndpointPropertiesInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdEndpointPropertiesUpdateParameters"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdEndpointPropertiesUpdateParameters __afdEndpointPropertiesUpdateParameters = new Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.AfdEndpointPropertiesUpdateParameters();

        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdStateProperties" />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdStateProperties __afdStateProperties = new Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.AfdStateProperties();

        /// <summary>Backing field for <see cref="AutoGeneratedDomainNameLabelScope" /> property.</summary>
        private string _autoGeneratedDomainNameLabelScope;

        /// <summary>Indicates the endpoint name reuse scope. The default value is TenantReuse.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public string AutoGeneratedDomainNameLabelScope { get => this._autoGeneratedDomainNameLabelScope; set => this._autoGeneratedDomainNameLabelScope = value; }

        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inherited)]
        public string DeploymentStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdStatePropertiesInternal)__afdStateProperties).DeploymentStatus; }

        /// <summary>
        /// Whether to enable use of this rule. Permitted values are 'Enabled' or 'Disabled'
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inherited)]
        public string EnabledState { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdEndpointPropertiesUpdateParametersInternal)__afdEndpointPropertiesUpdateParameters).EnabledState; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdEndpointPropertiesUpdateParametersInternal)__afdEndpointPropertiesUpdateParameters).EnabledState = value ?? null; }

        /// <summary>Backing field for <see cref="HostName" /> property.</summary>
        private string _hostName;

        /// <summary>
        /// The host name of the endpoint structured as {endpointName}.{DNSZone}, e.g. contoso.azureedge.net
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public string HostName { get => this._hostName; }

        /// <summary>Internal Acessors for HostName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdEndpointPropertiesInternal.HostName { get => this._hostName; set { {_hostName = value;} } }

        /// <summary>Internal Acessors for ProfileName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdEndpointPropertiesUpdateParametersInternal.ProfileName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdEndpointPropertiesUpdateParametersInternal)__afdEndpointPropertiesUpdateParameters).ProfileName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdEndpointPropertiesUpdateParametersInternal)__afdEndpointPropertiesUpdateParameters).ProfileName = value; }

        /// <summary>Internal Acessors for DeploymentStatus</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdStatePropertiesInternal.DeploymentStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdStatePropertiesInternal)__afdStateProperties).DeploymentStatus; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdStatePropertiesInternal)__afdStateProperties).DeploymentStatus = value; }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdStatePropertiesInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdStatePropertiesInternal)__afdStateProperties).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdStatePropertiesInternal)__afdStateProperties).ProvisioningState = value; }

        /// <summary>The name of the profile which holds the endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inherited)]
        public string ProfileName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdEndpointPropertiesUpdateParametersInternal)__afdEndpointPropertiesUpdateParameters).ProfileName; }

        /// <summary>Provisioning status</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inherited)]
        public string ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdStatePropertiesInternal)__afdStateProperties).ProvisioningState; }

        /// <summary>Creates an new <see cref="AfdEndpointProperties" /> instance.</summary>
        public AfdEndpointProperties()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__afdEndpointPropertiesUpdateParameters), __afdEndpointPropertiesUpdateParameters);
            await eventListener.AssertObjectIsValid(nameof(__afdEndpointPropertiesUpdateParameters), __afdEndpointPropertiesUpdateParameters);
            await eventListener.AssertNotNull(nameof(__afdStateProperties), __afdStateProperties);
            await eventListener.AssertObjectIsValid(nameof(__afdStateProperties), __afdStateProperties);
        }
    }
    /// The JSON object that contains the properties required to create an endpoint.
    public partial interface IAfdEndpointProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdEndpointPropertiesUpdateParameters,
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdStateProperties
    {
        /// <summary>Indicates the endpoint name reuse scope. The default value is TenantReuse.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Indicates the endpoint name reuse scope. The default value is TenantReuse.",
        SerializedName = @"autoGeneratedDomainNameLabelScope",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Cdn.PSArgumentCompleterAttribute("TenantReuse", "SubscriptionReuse", "ResourceGroupReuse", "NoReuse")]
        string AutoGeneratedDomainNameLabelScope { get; set; }
        /// <summary>
        /// The host name of the endpoint structured as {endpointName}.{DNSZone}, e.g. contoso.azureedge.net
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The host name of the endpoint structured as {endpointName}.{DNSZone}, e.g. contoso.azureedge.net",
        SerializedName = @"hostName",
        PossibleTypes = new [] { typeof(string) })]
        string HostName { get;  }

    }
    /// The JSON object that contains the properties required to create an endpoint.
    internal partial interface IAfdEndpointPropertiesInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdEndpointPropertiesUpdateParametersInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdStatePropertiesInternal
    {
        /// <summary>Indicates the endpoint name reuse scope. The default value is TenantReuse.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Cdn.PSArgumentCompleterAttribute("TenantReuse", "SubscriptionReuse", "ResourceGroupReuse", "NoReuse")]
        string AutoGeneratedDomainNameLabelScope { get; set; }
        /// <summary>
        /// The host name of the endpoint structured as {endpointName}.{DNSZone}, e.g. contoso.azureedge.net
        /// </summary>
        string HostName { get; set; }

    }
}