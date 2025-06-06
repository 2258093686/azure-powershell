// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Runtime.Extensions;

    /// <summary>Specifies that the scope of the extension is Cluster</summary>
    public partial class ScopeCluster :
        Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.IScopeCluster,
        Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.IScopeClusterInternal
    {

        /// <summary>Backing field for <see cref="ReleaseNamespace" /> property.</summary>
        private string _releaseNamespace;

        /// <summary>
        /// Namespace where the extension Release must be placed, for a Cluster scoped extension. If this namespace does not exist,
        /// it will be created
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.PropertyOrigin.Owned)]
        public string ReleaseNamespace { get => this._releaseNamespace; set => this._releaseNamespace = value; }

        /// <summary>Creates an new <see cref="ScopeCluster" /> instance.</summary>
        public ScopeCluster()
        {

        }
    }
    /// Specifies that the scope of the extension is Cluster
    public partial interface IScopeCluster :
        Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Namespace where the extension Release must be placed, for a Cluster scoped extension. If this namespace does not exist,
        /// it will be created
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Namespace where the extension Release must be placed, for a Cluster scoped extension.  If this namespace does not exist, it will be created",
        SerializedName = @"releaseNamespace",
        PossibleTypes = new [] { typeof(string) })]
        string ReleaseNamespace { get; set; }

    }
    /// Specifies that the scope of the extension is Cluster
    internal partial interface IScopeClusterInternal

    {
        /// <summary>
        /// Namespace where the extension Release must be placed, for a Cluster scoped extension. If this namespace does not exist,
        /// it will be created
        /// </summary>
        string ReleaseNamespace { get; set; }

    }
}