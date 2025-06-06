// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201
{
    using Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.PowerShell;

    /// <summary>The base class for the secrets</summary>
    [System.ComponentModel.TypeConverter(typeof(JobSecretsTypeConverter))]
    public partial class JobSecrets
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.JobSecrets"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecrets" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecrets DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new JobSecrets(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.JobSecrets"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecrets" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecrets DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new JobSecrets(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="JobSecrets" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="JobSecrets" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecrets FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.JobSecrets"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal JobSecrets(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("DcAccessSecurityCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal)this).DcAccessSecurityCode = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IDcAccessSecurityCode) content.GetValueForProperty("DcAccessSecurityCode",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal)this).DcAccessSecurityCode, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.DcAccessSecurityCodeTypeConverter.ConvertFrom);
            }
            if (content.Contains("Error"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal)this).Error = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.ICloudError) content.GetValueForProperty("Error",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal)this).Error, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.CloudErrorTypeConverter.ConvertFrom);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal)this).Type = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.ClassDiscriminator) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal)this).Type, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.ClassDiscriminator.CreateFrom);
            }
            if (content.Contains("DcAccessSecurityCodeReverseDcAccessCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal)this).DcAccessSecurityCodeReverseDcAccessCode = (string) content.GetValueForProperty("DcAccessSecurityCodeReverseDcAccessCode",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal)this).DcAccessSecurityCodeReverseDcAccessCode, global::System.Convert.ToString);
            }
            if (content.Contains("DcAccessSecurityCodeForwardDcAccessCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal)this).DcAccessSecurityCodeForwardDcAccessCode = (string) content.GetValueForProperty("DcAccessSecurityCodeForwardDcAccessCode",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal)this).DcAccessSecurityCodeForwardDcAccessCode, global::System.Convert.ToString);
            }
            if (content.Contains("AdditionalInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal)this).AdditionalInfo = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IAdditionalErrorInfo[]) content.GetValueForProperty("AdditionalInfo",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal)this).AdditionalInfo, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IAdditionalErrorInfo>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.AdditionalErrorInfoTypeConverter.ConvertFrom));
            }
            if (content.Contains("Code"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal)this).Code = (string) content.GetValueForProperty("Code",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal)this).Code, global::System.Convert.ToString);
            }
            if (content.Contains("Detail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal)this).Detail = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.ICloudError[]) content.GetValueForProperty("Detail",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal)this).Detail, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.ICloudError>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.CloudErrorTypeConverter.ConvertFrom));
            }
            if (content.Contains("Message"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal)this).Message = (string) content.GetValueForProperty("Message",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal)this).Message, global::System.Convert.ToString);
            }
            if (content.Contains("Target"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal)this).Target = (string) content.GetValueForProperty("Target",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal)this).Target, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.JobSecrets"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal JobSecrets(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("DcAccessSecurityCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal)this).DcAccessSecurityCode = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IDcAccessSecurityCode) content.GetValueForProperty("DcAccessSecurityCode",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal)this).DcAccessSecurityCode, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.DcAccessSecurityCodeTypeConverter.ConvertFrom);
            }
            if (content.Contains("Error"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal)this).Error = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.ICloudError) content.GetValueForProperty("Error",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal)this).Error, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.CloudErrorTypeConverter.ConvertFrom);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal)this).Type = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.ClassDiscriminator) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal)this).Type, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.ClassDiscriminator.CreateFrom);
            }
            if (content.Contains("DcAccessSecurityCodeReverseDcAccessCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal)this).DcAccessSecurityCodeReverseDcAccessCode = (string) content.GetValueForProperty("DcAccessSecurityCodeReverseDcAccessCode",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal)this).DcAccessSecurityCodeReverseDcAccessCode, global::System.Convert.ToString);
            }
            if (content.Contains("DcAccessSecurityCodeForwardDcAccessCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal)this).DcAccessSecurityCodeForwardDcAccessCode = (string) content.GetValueForProperty("DcAccessSecurityCodeForwardDcAccessCode",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal)this).DcAccessSecurityCodeForwardDcAccessCode, global::System.Convert.ToString);
            }
            if (content.Contains("AdditionalInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal)this).AdditionalInfo = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IAdditionalErrorInfo[]) content.GetValueForProperty("AdditionalInfo",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal)this).AdditionalInfo, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IAdditionalErrorInfo>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.AdditionalErrorInfoTypeConverter.ConvertFrom));
            }
            if (content.Contains("Code"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal)this).Code = (string) content.GetValueForProperty("Code",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal)this).Code, global::System.Convert.ToString);
            }
            if (content.Contains("Detail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal)this).Detail = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.ICloudError[]) content.GetValueForProperty("Detail",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal)this).Detail, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.ICloudError>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.CloudErrorTypeConverter.ConvertFrom));
            }
            if (content.Contains("Message"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal)this).Message = (string) content.GetValueForProperty("Message",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal)this).Message, global::System.Convert.ToString);
            }
            if (content.Contains("Target"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal)this).Target = (string) content.GetValueForProperty("Target",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal)this).Target, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// The base class for the secrets
    [System.ComponentModel.TypeConverter(typeof(JobSecretsTypeConverter))]
    public partial interface IJobSecrets

    {

    }
}