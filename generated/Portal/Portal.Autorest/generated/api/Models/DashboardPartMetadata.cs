// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Portal.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Portal.Runtime.Extensions;

    /// <summary>A dashboard part metadata.</summary>
    public partial class DashboardPartMetadata :
        Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.IDashboardPartMetadata,
        Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.IDashboardPartMetadataInternal
    {

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.IDashboardPartMetadataInternal.Type { get => this._type; set { {_type = value;} } }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type= @"Extension/HubsExtension/PartType/MarkdownPart";

        /// <summary>The dashboard part metadata type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Portal.Origin(Microsoft.Azure.PowerShell.Cmdlets.Portal.PropertyOrigin.Owned)]
        public string Type { get => this._type; }

        /// <summary>Creates an new <see cref="DashboardPartMetadata" /> instance.</summary>
        public DashboardPartMetadata()
        {

        }
    }
    /// A dashboard part metadata.
    public partial interface IDashboardPartMetadata :
        Microsoft.Azure.PowerShell.Cmdlets.Portal.Runtime.IJsonSerializable
    {
        /// <summary>The dashboard part metadata type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Portal.Runtime.Info(
        Required = true,
        ReadOnly = true,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The dashboard part metadata type.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string Type { get;  }

    }
    /// A dashboard part metadata.
    internal partial interface IDashboardPartMetadataInternal

    {
        /// <summary>The dashboard part metadata type.</summary>
        string Type { get; set; }

    }
}