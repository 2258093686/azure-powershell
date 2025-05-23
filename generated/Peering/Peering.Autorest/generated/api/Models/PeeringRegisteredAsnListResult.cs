// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Peering.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.Extensions;

    /// <summary>The paginated list of peering registered ASNs.</summary>
    public partial class PeeringRegisteredAsnListResult :
        Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.IPeeringRegisteredAsnListResult,
        Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.IPeeringRegisteredAsnListResultInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>The link to fetch the next page of peering registered ASNs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.Origin(Microsoft.Azure.PowerShell.Cmdlets.Peering.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.IPeeringRegisteredAsn> _value;

        /// <summary>The list of peering registered ASNs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.Origin(Microsoft.Azure.PowerShell.Cmdlets.Peering.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.IPeeringRegisteredAsn> Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="PeeringRegisteredAsnListResult" /> instance.</summary>
        public PeeringRegisteredAsnListResult()
        {

        }
    }
    /// The paginated list of peering registered ASNs.
    public partial interface IPeeringRegisteredAsnListResult :
        Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.IJsonSerializable
    {
        /// <summary>The link to fetch the next page of peering registered ASNs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The link to fetch the next page of peering registered ASNs.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>The list of peering registered ASNs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The list of peering registered ASNs.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.IPeeringRegisteredAsn) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.IPeeringRegisteredAsn> Value { get; set; }

    }
    /// The paginated list of peering registered ASNs.
    internal partial interface IPeeringRegisteredAsnListResultInternal

    {
        /// <summary>The link to fetch the next page of peering registered ASNs.</summary>
        string NextLink { get; set; }
        /// <summary>The list of peering registered ASNs.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.IPeeringRegisteredAsn> Value { get; set; }

    }
}