// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.PowerShell;

    /// <summary>
    /// Defines the certificate source parameters using user's keyvault certificate for enabling SSL.
    /// </summary>
    [System.ComponentModel.TypeConverter(typeof(UserManagedHttpsParametersTypeConverter))]
    public partial class UserManagedHttpsParameters
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// <c>OverrideToString</c> will be called if it is implemented. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="stringResult">/// instance serialized to a string, normally it is a Json</param>
        /// <param name="returnNow">/// set returnNow to true if you provide a customized OverrideToString function</param>

        partial void OverrideToString(ref string stringResult, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.UserManagedHttpsParameters"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IUserManagedHttpsParameters" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IUserManagedHttpsParameters DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new UserManagedHttpsParameters(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.UserManagedHttpsParameters"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IUserManagedHttpsParameters" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IUserManagedHttpsParameters DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new UserManagedHttpsParameters(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="UserManagedHttpsParameters" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="UserManagedHttpsParameters" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IUserManagedHttpsParameters FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.SerializationMode.IncludeAll)?.ToString();

        public override string ToString()
        {
            var returnNow = false;
            var result = global::System.String.Empty;
            OverrideToString(ref result, ref returnNow);
            if (returnNow)
            {
                return result;
            }
            return ToJsonString();
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.UserManagedHttpsParameters"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal UserManagedHttpsParameters(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("CertificateSourceParameter"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IUserManagedHttpsParametersInternal)this).CertificateSourceParameter = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IKeyVaultCertificateSourceParameters) content.GetValueForProperty("CertificateSourceParameter",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IUserManagedHttpsParametersInternal)this).CertificateSourceParameter, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.KeyVaultCertificateSourceParametersTypeConverter.ConvertFrom);
            }
            if (content.Contains("CertificateSource"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.ICustomDomainHttpsParametersInternal)this).CertificateSource = (string) content.GetValueForProperty("CertificateSource",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.ICustomDomainHttpsParametersInternal)this).CertificateSource, global::System.Convert.ToString);
            }
            if (content.Contains("ProtocolType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.ICustomDomainHttpsParametersInternal)this).ProtocolType = (string) content.GetValueForProperty("ProtocolType",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.ICustomDomainHttpsParametersInternal)this).ProtocolType, global::System.Convert.ToString);
            }
            if (content.Contains("MinimumTlsVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.ICustomDomainHttpsParametersInternal)this).MinimumTlsVersion = (string) content.GetValueForProperty("MinimumTlsVersion",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.ICustomDomainHttpsParametersInternal)this).MinimumTlsVersion, global::System.Convert.ToString);
            }
            if (content.Contains("CertificateSourceParameterTypeName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IUserManagedHttpsParametersInternal)this).CertificateSourceParameterTypeName = (string) content.GetValueForProperty("CertificateSourceParameterTypeName",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IUserManagedHttpsParametersInternal)this).CertificateSourceParameterTypeName, global::System.Convert.ToString);
            }
            if (content.Contains("CertificateSourceParameterUpdateRule"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IUserManagedHttpsParametersInternal)this).CertificateSourceParameterUpdateRule = (string) content.GetValueForProperty("CertificateSourceParameterUpdateRule",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IUserManagedHttpsParametersInternal)this).CertificateSourceParameterUpdateRule, global::System.Convert.ToString);
            }
            if (content.Contains("CertificateSourceParameterDeleteRule"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IUserManagedHttpsParametersInternal)this).CertificateSourceParameterDeleteRule = (string) content.GetValueForProperty("CertificateSourceParameterDeleteRule",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IUserManagedHttpsParametersInternal)this).CertificateSourceParameterDeleteRule, global::System.Convert.ToString);
            }
            if (content.Contains("CertificateSourceParameterSubscriptionId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IUserManagedHttpsParametersInternal)this).CertificateSourceParameterSubscriptionId = (string) content.GetValueForProperty("CertificateSourceParameterSubscriptionId",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IUserManagedHttpsParametersInternal)this).CertificateSourceParameterSubscriptionId, global::System.Convert.ToString);
            }
            if (content.Contains("CertificateSourceParameterResourceGroupName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IUserManagedHttpsParametersInternal)this).CertificateSourceParameterResourceGroupName = (string) content.GetValueForProperty("CertificateSourceParameterResourceGroupName",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IUserManagedHttpsParametersInternal)this).CertificateSourceParameterResourceGroupName, global::System.Convert.ToString);
            }
            if (content.Contains("CertificateSourceParameterVaultName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IUserManagedHttpsParametersInternal)this).CertificateSourceParameterVaultName = (string) content.GetValueForProperty("CertificateSourceParameterVaultName",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IUserManagedHttpsParametersInternal)this).CertificateSourceParameterVaultName, global::System.Convert.ToString);
            }
            if (content.Contains("CertificateSourceParameterSecretName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IUserManagedHttpsParametersInternal)this).CertificateSourceParameterSecretName = (string) content.GetValueForProperty("CertificateSourceParameterSecretName",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IUserManagedHttpsParametersInternal)this).CertificateSourceParameterSecretName, global::System.Convert.ToString);
            }
            if (content.Contains("CertificateSourceParameterSecretVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IUserManagedHttpsParametersInternal)this).CertificateSourceParameterSecretVersion = (string) content.GetValueForProperty("CertificateSourceParameterSecretVersion",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IUserManagedHttpsParametersInternal)this).CertificateSourceParameterSecretVersion, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.UserManagedHttpsParameters"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal UserManagedHttpsParameters(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("CertificateSourceParameter"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IUserManagedHttpsParametersInternal)this).CertificateSourceParameter = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IKeyVaultCertificateSourceParameters) content.GetValueForProperty("CertificateSourceParameter",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IUserManagedHttpsParametersInternal)this).CertificateSourceParameter, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.KeyVaultCertificateSourceParametersTypeConverter.ConvertFrom);
            }
            if (content.Contains("CertificateSource"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.ICustomDomainHttpsParametersInternal)this).CertificateSource = (string) content.GetValueForProperty("CertificateSource",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.ICustomDomainHttpsParametersInternal)this).CertificateSource, global::System.Convert.ToString);
            }
            if (content.Contains("ProtocolType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.ICustomDomainHttpsParametersInternal)this).ProtocolType = (string) content.GetValueForProperty("ProtocolType",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.ICustomDomainHttpsParametersInternal)this).ProtocolType, global::System.Convert.ToString);
            }
            if (content.Contains("MinimumTlsVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.ICustomDomainHttpsParametersInternal)this).MinimumTlsVersion = (string) content.GetValueForProperty("MinimumTlsVersion",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.ICustomDomainHttpsParametersInternal)this).MinimumTlsVersion, global::System.Convert.ToString);
            }
            if (content.Contains("CertificateSourceParameterTypeName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IUserManagedHttpsParametersInternal)this).CertificateSourceParameterTypeName = (string) content.GetValueForProperty("CertificateSourceParameterTypeName",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IUserManagedHttpsParametersInternal)this).CertificateSourceParameterTypeName, global::System.Convert.ToString);
            }
            if (content.Contains("CertificateSourceParameterUpdateRule"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IUserManagedHttpsParametersInternal)this).CertificateSourceParameterUpdateRule = (string) content.GetValueForProperty("CertificateSourceParameterUpdateRule",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IUserManagedHttpsParametersInternal)this).CertificateSourceParameterUpdateRule, global::System.Convert.ToString);
            }
            if (content.Contains("CertificateSourceParameterDeleteRule"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IUserManagedHttpsParametersInternal)this).CertificateSourceParameterDeleteRule = (string) content.GetValueForProperty("CertificateSourceParameterDeleteRule",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IUserManagedHttpsParametersInternal)this).CertificateSourceParameterDeleteRule, global::System.Convert.ToString);
            }
            if (content.Contains("CertificateSourceParameterSubscriptionId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IUserManagedHttpsParametersInternal)this).CertificateSourceParameterSubscriptionId = (string) content.GetValueForProperty("CertificateSourceParameterSubscriptionId",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IUserManagedHttpsParametersInternal)this).CertificateSourceParameterSubscriptionId, global::System.Convert.ToString);
            }
            if (content.Contains("CertificateSourceParameterResourceGroupName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IUserManagedHttpsParametersInternal)this).CertificateSourceParameterResourceGroupName = (string) content.GetValueForProperty("CertificateSourceParameterResourceGroupName",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IUserManagedHttpsParametersInternal)this).CertificateSourceParameterResourceGroupName, global::System.Convert.ToString);
            }
            if (content.Contains("CertificateSourceParameterVaultName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IUserManagedHttpsParametersInternal)this).CertificateSourceParameterVaultName = (string) content.GetValueForProperty("CertificateSourceParameterVaultName",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IUserManagedHttpsParametersInternal)this).CertificateSourceParameterVaultName, global::System.Convert.ToString);
            }
            if (content.Contains("CertificateSourceParameterSecretName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IUserManagedHttpsParametersInternal)this).CertificateSourceParameterSecretName = (string) content.GetValueForProperty("CertificateSourceParameterSecretName",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IUserManagedHttpsParametersInternal)this).CertificateSourceParameterSecretName, global::System.Convert.ToString);
            }
            if (content.Contains("CertificateSourceParameterSecretVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IUserManagedHttpsParametersInternal)this).CertificateSourceParameterSecretVersion = (string) content.GetValueForProperty("CertificateSourceParameterSecretVersion",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IUserManagedHttpsParametersInternal)this).CertificateSourceParameterSecretVersion, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }
    }
    /// Defines the certificate source parameters using user's keyvault certificate for enabling SSL.
    [System.ComponentModel.TypeConverter(typeof(UserManagedHttpsParametersTypeConverter))]
    public partial interface IUserManagedHttpsParameters

    {

    }
}