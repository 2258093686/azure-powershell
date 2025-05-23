// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Extensions;

    /// <summary>The list of product families.</summary>
    public partial class ProductFamilies :
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IProductFamilies,
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IProductFamiliesInternal
    {

        /// <summary>Internal Acessors for Value</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IProductFamily> Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IProductFamiliesInternal.Value { get => this._value; set { {_value = value;} } }

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>Link for the next set of product families.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IProductFamily> _value;

        /// <summary>List of product families.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IProductFamily> Value { get => this._value; }

        /// <summary>Creates an new <see cref="ProductFamilies" /> instance.</summary>
        public ProductFamilies()
        {

        }
    }
    /// The list of product families.
    public partial interface IProductFamilies :
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.IJsonSerializable
    {
        /// <summary>Link for the next set of product families.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Link for the next set of product families.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>List of product families.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"List of product families.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IProductFamily) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IProductFamily> Value { get;  }

    }
    /// The list of product families.
    internal partial interface IProductFamiliesInternal

    {
        /// <summary>Link for the next set of product families.</summary>
        string NextLink { get; set; }
        /// <summary>List of product families.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IProductFamily> Value { get; set; }

    }
}