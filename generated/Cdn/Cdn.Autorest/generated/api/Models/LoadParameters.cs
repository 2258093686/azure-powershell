// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Extensions;

    /// <summary>Parameters required for content load.</summary>
    public partial class LoadParameters :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.ILoadParameters,
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.ILoadParametersInternal
    {

        /// <summary>Backing field for <see cref="ContentPath" /> property.</summary>
        private System.Collections.Generic.List<string> _contentPath;

        /// <summary>
        /// The path to the content to be loaded. Path should be a relative file URL of the origin.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> ContentPath { get => this._contentPath; set => this._contentPath = value; }

        /// <summary>Creates an new <see cref="LoadParameters" /> instance.</summary>
        public LoadParameters()
        {

        }
    }
    /// Parameters required for content load.
    public partial interface ILoadParameters :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The path to the content to be loaded. Path should be a relative file URL of the origin.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The path to the content to be loaded. Path should be a relative file URL of the origin.",
        SerializedName = @"contentPaths",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> ContentPath { get; set; }

    }
    /// Parameters required for content load.
    internal partial interface ILoadParametersInternal

    {
        /// <summary>
        /// The path to the content to be loaded. Path should be a relative file URL of the origin.
        /// </summary>
        System.Collections.Generic.List<string> ContentPath { get; set; }

    }
}