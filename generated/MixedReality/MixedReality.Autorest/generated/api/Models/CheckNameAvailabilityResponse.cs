// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MixedReality.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MixedReality.Runtime.Extensions;

    /// <summary>Check Name Availability Response</summary>
    public partial class CheckNameAvailabilityResponse :
        Microsoft.Azure.PowerShell.Cmdlets.MixedReality.Models.ICheckNameAvailabilityResponse,
        Microsoft.Azure.PowerShell.Cmdlets.MixedReality.Models.ICheckNameAvailabilityResponseInternal
    {

        /// <summary>Backing field for <see cref="Message" /> property.</summary>
        private string _message;

        /// <summary>detail message</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MixedReality.Origin(Microsoft.Azure.PowerShell.Cmdlets.MixedReality.PropertyOrigin.Owned)]
        public string Message { get => this._message; set => this._message = value; }

        /// <summary>Backing field for <see cref="NameAvailable" /> property.</summary>
        private bool _nameAvailable;

        /// <summary>if name Available</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MixedReality.Origin(Microsoft.Azure.PowerShell.Cmdlets.MixedReality.PropertyOrigin.Owned)]
        public bool NameAvailable { get => this._nameAvailable; set => this._nameAvailable = value; }

        /// <summary>Backing field for <see cref="Reason" /> property.</summary>
        private string _reason;

        /// <summary>Resource Name To Verify</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MixedReality.Origin(Microsoft.Azure.PowerShell.Cmdlets.MixedReality.PropertyOrigin.Owned)]
        public string Reason { get => this._reason; set => this._reason = value; }

        /// <summary>Creates an new <see cref="CheckNameAvailabilityResponse" /> instance.</summary>
        public CheckNameAvailabilityResponse()
        {

        }
    }
    /// Check Name Availability Response
    public partial interface ICheckNameAvailabilityResponse :
        Microsoft.Azure.PowerShell.Cmdlets.MixedReality.Runtime.IJsonSerializable
    {
        /// <summary>detail message</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MixedReality.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"detail message",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string Message { get; set; }
        /// <summary>if name Available</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MixedReality.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"if name Available",
        SerializedName = @"nameAvailable",
        PossibleTypes = new [] { typeof(bool) })]
        bool NameAvailable { get; set; }
        /// <summary>Resource Name To Verify</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MixedReality.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Resource Name To Verify",
        SerializedName = @"reason",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MixedReality.PSArgumentCompleterAttribute("Invalid", "AlreadyExists")]
        string Reason { get; set; }

    }
    /// Check Name Availability Response
    internal partial interface ICheckNameAvailabilityResponseInternal

    {
        /// <summary>detail message</summary>
        string Message { get; set; }
        /// <summary>if name Available</summary>
        bool NameAvailable { get; set; }
        /// <summary>Resource Name To Verify</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.MixedReality.PSArgumentCompleterAttribute("Invalid", "AlreadyExists")]
        string Reason { get; set; }

    }
}