// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Extensions;

    /// <summary>Source LifeCycle</summary>
    public partial class SourceLifeCycle :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.ISourceLifeCycle,
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.ISourceLifeCycleInternal
    {

        /// <summary>Backing field for <see cref="DeleteAfter" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IDeleteOption _deleteAfter;

        /// <summary>Delete Option</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IDeleteOption DeleteAfter { get => (this._deleteAfter = this._deleteAfter ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.DeleteOption()); set => this._deleteAfter = value; }

        /// <summary>Duration of deletion after given timespan</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string DeleteAfterDuration { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IDeleteOptionInternal)DeleteAfter).Duration; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IDeleteOptionInternal)DeleteAfter).Duration = value ; }

        /// <summary>Type of the specific object - used for deserializing</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string DeleteAfterObjectType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IDeleteOptionInternal)DeleteAfter).ObjectType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IDeleteOptionInternal)DeleteAfter).ObjectType = value ; }

        /// <summary>Internal Acessors for DeleteAfter</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IDeleteOption Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.ISourceLifeCycleInternal.DeleteAfter { get => (this._deleteAfter = this._deleteAfter ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.DeleteOption()); set { {_deleteAfter = value;} } }

        /// <summary>Internal Acessors for SourceDataStore</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IDataStoreInfoBase Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.ISourceLifeCycleInternal.SourceDataStore { get => (this._sourceDataStore = this._sourceDataStore ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.DataStoreInfoBase()); set { {_sourceDataStore = value;} } }

        /// <summary>Backing field for <see cref="SourceDataStore" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IDataStoreInfoBase _sourceDataStore;

        /// <summary>DataStoreInfo base</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IDataStoreInfoBase SourceDataStore { get => (this._sourceDataStore = this._sourceDataStore ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.DataStoreInfoBase()); set => this._sourceDataStore = value; }

        /// <summary>Type of Datasource object, used to initialize the right inherited type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string SourceDataStoreObjectType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IDataStoreInfoBaseInternal)SourceDataStore).ObjectType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IDataStoreInfoBaseInternal)SourceDataStore).ObjectType = value ; }

        /// <summary>type of datastore; Operational/Vault/Archive</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.DataStoreTypes SourceDataStoreType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IDataStoreInfoBaseInternal)SourceDataStore).DataStoreType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IDataStoreInfoBaseInternal)SourceDataStore).DataStoreType = value ; }

        /// <summary>Backing field for <see cref="TargetDataStoreCopySetting" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.ITargetCopySetting[] _targetDataStoreCopySetting;

        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.ITargetCopySetting[] TargetDataStoreCopySetting { get => this._targetDataStoreCopySetting; set => this._targetDataStoreCopySetting = value; }

        /// <summary>Creates an new <see cref="SourceLifeCycle" /> instance.</summary>
        public SourceLifeCycle()
        {

        }
    }
    /// Source LifeCycle
    public partial interface ISourceLifeCycle :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.IJsonSerializable
    {
        /// <summary>Duration of deletion after given timespan</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Duration of deletion after given timespan",
        SerializedName = @"duration",
        PossibleTypes = new [] { typeof(string) })]
        string DeleteAfterDuration { get; set; }
        /// <summary>Type of the specific object - used for deserializing</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Type of the specific object - used for deserializing",
        SerializedName = @"objectType",
        PossibleTypes = new [] { typeof(string) })]
        string DeleteAfterObjectType { get; set; }
        /// <summary>Type of Datasource object, used to initialize the right inherited type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Type of Datasource object, used to initialize the right inherited type",
        SerializedName = @"objectType",
        PossibleTypes = new [] { typeof(string) })]
        string SourceDataStoreObjectType { get; set; }
        /// <summary>type of datastore; Operational/Vault/Archive</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"type of datastore; Operational/Vault/Archive",
        SerializedName = @"dataStoreType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.DataStoreTypes) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.DataStoreTypes SourceDataStoreType { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"targetDataStoreCopySettings",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.ITargetCopySetting) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.ITargetCopySetting[] TargetDataStoreCopySetting { get; set; }

    }
    /// Source LifeCycle
    internal partial interface ISourceLifeCycleInternal

    {
        /// <summary>Delete Option</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IDeleteOption DeleteAfter { get; set; }
        /// <summary>Duration of deletion after given timespan</summary>
        string DeleteAfterDuration { get; set; }
        /// <summary>Type of the specific object - used for deserializing</summary>
        string DeleteAfterObjectType { get; set; }
        /// <summary>DataStoreInfo base</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IDataStoreInfoBase SourceDataStore { get; set; }
        /// <summary>Type of Datasource object, used to initialize the right inherited type</summary>
        string SourceDataStoreObjectType { get; set; }
        /// <summary>type of datastore; Operational/Vault/Archive</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.DataStoreTypes SourceDataStoreType { get; set; }

        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.ITargetCopySetting[] TargetDataStoreCopySetting { get; set; }

    }
}