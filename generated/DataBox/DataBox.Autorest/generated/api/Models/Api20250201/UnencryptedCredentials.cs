// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Extensions;

    /// <summary>Unencrypted credentials for accessing device.</summary>
    public partial class UnencryptedCredentials :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IUnencryptedCredentials,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IUnencryptedCredentialsInternal
    {

        /// <summary>Gets or sets additional error info.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IAdditionalErrorInfo[] AdditionalInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal)JobSecret).AdditionalInfo; }

        /// <summary>Error code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string Code { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal)JobSecret).Code; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal)JobSecret).Code = value ?? null; }

        /// <summary>Forward Dc access security code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string DcAccessSecurityCodeForwardDcAccessCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal)JobSecret).DcAccessSecurityCodeForwardDcAccessCode; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal)JobSecret).DcAccessSecurityCodeForwardDcAccessCode = value ?? null; }

        /// <summary>Reverse Dc access security code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string DcAccessSecurityCodeReverseDcAccessCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal)JobSecret).DcAccessSecurityCodeReverseDcAccessCode; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal)JobSecret).DcAccessSecurityCodeReverseDcAccessCode = value ?? null; }

        /// <summary>Gets or sets details for the error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.ICloudError[] Detail { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal)JobSecret).Detail; }

        /// <summary>Backing field for <see cref="JobName" /> property.</summary>
        private string _jobName;

        /// <summary>Name of the job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string JobName { get => this._jobName; }

        /// <summary>Backing field for <see cref="JobSecret" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecrets _jobSecret;

        /// <summary>Secrets related to this job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecrets JobSecret { get => (this._jobSecret = this._jobSecret ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.JobSecrets()); }

        /// <summary>Used to indicate what type of job secrets object.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.ClassDiscriminator? JobSecretJobSecretsType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal)JobSecret).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal)JobSecret).Type = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.ClassDiscriminator)""); }

        /// <summary>The error message parsed from the body of the http error response.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string Message { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal)JobSecret).Message; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal)JobSecret).Message = value ?? null; }

        /// <summary>Internal Acessors for AdditionalInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IAdditionalErrorInfo[] Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IUnencryptedCredentialsInternal.AdditionalInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal)JobSecret).AdditionalInfo; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal)JobSecret).AdditionalInfo = value; }

        /// <summary>Internal Acessors for Detail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.ICloudError[] Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IUnencryptedCredentialsInternal.Detail { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal)JobSecret).Detail; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal)JobSecret).Detail = value; }

        /// <summary>Internal Acessors for JobName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IUnencryptedCredentialsInternal.JobName { get => this._jobName; set { {_jobName = value;} } }

        /// <summary>Internal Acessors for JobSecret</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecrets Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IUnencryptedCredentialsInternal.JobSecret { get => (this._jobSecret = this._jobSecret ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.JobSecrets()); set { {_jobSecret = value;} } }

        /// <summary>Internal Acessors for JobSecretDcAccessSecurityCode</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IDcAccessSecurityCode Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IUnencryptedCredentialsInternal.JobSecretDcAccessSecurityCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal)JobSecret).DcAccessSecurityCode; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal)JobSecret).DcAccessSecurityCode = value; }

        /// <summary>Internal Acessors for JobSecretError</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.ICloudError Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IUnencryptedCredentialsInternal.JobSecretError { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal)JobSecret).Error; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal)JobSecret).Error = value; }

        /// <summary>Gets or sets the target of the error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string Target { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal)JobSecret).Target; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal)JobSecret).Target = value ?? null; }

        /// <summary>Creates an new <see cref="UnencryptedCredentials" /> instance.</summary>
        public UnencryptedCredentials()
        {

        }
    }
    /// Unencrypted credentials for accessing device.
    public partial interface IUnencryptedCredentials :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IJsonSerializable
    {
        /// <summary>Gets or sets additional error info.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Gets or sets additional error info.",
        SerializedName = @"additionalInfo",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IAdditionalErrorInfo) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IAdditionalErrorInfo[] AdditionalInfo { get;  }
        /// <summary>Error code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Error code.",
        SerializedName = @"code",
        PossibleTypes = new [] { typeof(string) })]
        string Code { get; set; }
        /// <summary>Forward Dc access security code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Forward Dc access security code.",
        SerializedName = @"forwardDCAccessCode",
        PossibleTypes = new [] { typeof(string) })]
        string DcAccessSecurityCodeForwardDcAccessCode { get; set; }
        /// <summary>Reverse Dc access security code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Reverse Dc access security code.",
        SerializedName = @"reverseDCAccessCode",
        PossibleTypes = new [] { typeof(string) })]
        string DcAccessSecurityCodeReverseDcAccessCode { get; set; }
        /// <summary>Gets or sets details for the error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Gets or sets details for the error.",
        SerializedName = @"details",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.ICloudError) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.ICloudError[] Detail { get;  }
        /// <summary>Name of the job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Name of the job.",
        SerializedName = @"jobName",
        PossibleTypes = new [] { typeof(string) })]
        string JobName { get;  }
        /// <summary>Used to indicate what type of job secrets object.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Used to indicate what type of job secrets object.",
        SerializedName = @"jobSecretsType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.ClassDiscriminator) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.ClassDiscriminator? JobSecretJobSecretsType { get; set; }
        /// <summary>The error message parsed from the body of the http error response.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The error message parsed from the body of the http error response.",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string Message { get; set; }
        /// <summary>Gets or sets the target of the error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets or sets the target of the error.",
        SerializedName = @"target",
        PossibleTypes = new [] { typeof(string) })]
        string Target { get; set; }

    }
    /// Unencrypted credentials for accessing device.
    internal partial interface IUnencryptedCredentialsInternal

    {
        /// <summary>Gets or sets additional error info.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IAdditionalErrorInfo[] AdditionalInfo { get; set; }
        /// <summary>Error code.</summary>
        string Code { get; set; }
        /// <summary>Forward Dc access security code.</summary>
        string DcAccessSecurityCodeForwardDcAccessCode { get; set; }
        /// <summary>Reverse Dc access security code.</summary>
        string DcAccessSecurityCodeReverseDcAccessCode { get; set; }
        /// <summary>Gets or sets details for the error.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.ICloudError[] Detail { get; set; }
        /// <summary>Name of the job.</summary>
        string JobName { get; set; }
        /// <summary>Secrets related to this job.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecrets JobSecret { get; set; }
        /// <summary>Dc Access Security Code for Customer Managed Shipping</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IDcAccessSecurityCode JobSecretDcAccessSecurityCode { get; set; }
        /// <summary>Error while fetching the secrets.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.ICloudError JobSecretError { get; set; }
        /// <summary>Used to indicate what type of job secrets object.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.ClassDiscriminator? JobSecretJobSecretsType { get; set; }
        /// <summary>The error message parsed from the body of the http error response.</summary>
        string Message { get; set; }
        /// <summary>Gets or sets the target of the error.</summary>
        string Target { get; set; }

    }
}