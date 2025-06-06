// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Runtime.Extensions;

    /// <summary>
    /// The secret info when type is keyVaultSecretUri. It's for scenario that user provides a secret stored in user's keyvault
    /// and source is Web App, Spring Cloud or Container App.
    /// </summary>
    public partial class KeyVaultSecretUriSecretInfo :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.IKeyVaultSecretUriSecretInfo,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.IKeyVaultSecretUriSecretInfoInternal,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.ISecretInfoBase"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.ISecretInfoBase __secretInfoBase = new Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.SecretInfoBase();

        /// <summary>The secret type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Constant]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.PropertyOrigin.Inherited)]
        public string SecretType { get => "keyVaultSecretUri"; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.ISecretInfoBaseInternal)__secretInfoBase).SecretType = "keyVaultSecretUri"; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private string _value;

        /// <summary>URI to the keyvault secret</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.PropertyOrigin.Owned)]
        public string Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="KeyVaultSecretUriSecretInfo" /> instance.</summary>
        public KeyVaultSecretUriSecretInfo()
        {
            this.__secretInfoBase.SecretType = "keyVaultSecretUri";
        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__secretInfoBase), __secretInfoBase);
            await eventListener.AssertObjectIsValid(nameof(__secretInfoBase), __secretInfoBase);
        }
    }
    /// The secret info when type is keyVaultSecretUri. It's for scenario that user provides a secret stored in user's keyvault
    /// and source is Web App, Spring Cloud or Container App.
    public partial interface IKeyVaultSecretUriSecretInfo :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.ISecretInfoBase
    {
        /// <summary>URI to the keyvault secret</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"URI to the keyvault secret",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(string) })]
        string Value { get; set; }

    }
    /// The secret info when type is keyVaultSecretUri. It's for scenario that user provides a secret stored in user's keyvault
    /// and source is Web App, Spring Cloud or Container App.
    internal partial interface IKeyVaultSecretUriSecretInfoInternal :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.ISecretInfoBaseInternal
    {
        /// <summary>URI to the keyvault secret</summary>
        string Value { get; set; }

    }
}