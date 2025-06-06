// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Extensions;

    /// <summary>Backup Vault Contract for Patch Backup Vault API.</summary>
    public partial class PatchBackupVaultInput :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IPatchBackupVaultInput,
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IPatchBackupVaultInputInternal
    {

        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.AlertsState? AzureMonitorAlertsForAllJobFailure { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IMonitoringSettingsInternal)MonitoringSetting).AzureMonitorAlertsForAllJobFailure; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IMonitoringSettingsInternal)MonitoringSetting).AzureMonitorAlertsForAllJobFailure = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.AlertsState)""); }

        /// <summary>CrossRegionRestore state</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.CrossRegionRestoreState? CrossRegionRestoreState { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IFeatureSettingsInternal)FeatureSetting).CrossRegionRestoreState; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IFeatureSettingsInternal)FeatureSetting).CrossRegionRestoreState = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.CrossRegionRestoreState)""); }

        /// <summary>CrossSubscriptionRestore state</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.CrossSubscriptionRestoreState? CrossSubscriptionRestoreState { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IFeatureSettingsInternal)FeatureSetting).CrossSubscriptionRestoreState; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IFeatureSettingsInternal)FeatureSetting).CrossSubscriptionRestoreState = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.CrossSubscriptionRestoreState)""); }

        /// <summary>Customer Managed Key details of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IEncryptionSettings EncryptionSetting { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.ISecuritySettingsInternal)SecuritySetting).EncryptionSetting; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.ISecuritySettingsInternal)SecuritySetting).EncryptionSetting = value ?? null /* model class */; }

        /// <summary>Backing field for <see cref="FeatureSetting" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IFeatureSettings _featureSetting;

        /// <summary>Feature Settings</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IFeatureSettings FeatureSetting { get => (this._featureSetting = this._featureSetting ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.FeatureSettings()); set => this._featureSetting = value; }

        /// <summary>Immutability state</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.ImmutabilityState? ImmutabilityState { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.ISecuritySettingsInternal)SecuritySetting).ImmutabilityState; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.ISecuritySettingsInternal)SecuritySetting).ImmutabilityState = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.ImmutabilityState)""); }

        /// <summary>Internal Acessors for FeatureSetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IFeatureSettings Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IPatchBackupVaultInputInternal.FeatureSetting { get => (this._featureSetting = this._featureSetting ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.FeatureSettings()); set { {_featureSetting = value;} } }

        /// <summary>Internal Acessors for FeatureSettingCrossRegionRestoreSetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.ICrossRegionRestoreSettings Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IPatchBackupVaultInputInternal.FeatureSettingCrossRegionRestoreSetting { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IFeatureSettingsInternal)FeatureSetting).CrossRegionRestoreSetting; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IFeatureSettingsInternal)FeatureSetting).CrossRegionRestoreSetting = value; }

        /// <summary>Internal Acessors for FeatureSettingCrossSubscriptionRestoreSetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.ICrossSubscriptionRestoreSettings Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IPatchBackupVaultInputInternal.FeatureSettingCrossSubscriptionRestoreSetting { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IFeatureSettingsInternal)FeatureSetting).CrossSubscriptionRestoreSetting; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IFeatureSettingsInternal)FeatureSetting).CrossSubscriptionRestoreSetting = value; }

        /// <summary>Internal Acessors for MonitoringSetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IMonitoringSettings Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IPatchBackupVaultInputInternal.MonitoringSetting { get => (this._monitoringSetting = this._monitoringSetting ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.MonitoringSettings()); set { {_monitoringSetting = value;} } }

        /// <summary>Internal Acessors for MonitoringSettingAzureMonitorAlertSetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IAzureMonitorAlertSettings Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IPatchBackupVaultInputInternal.MonitoringSettingAzureMonitorAlertSetting { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IMonitoringSettingsInternal)MonitoringSetting).AzureMonitorAlertSetting; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IMonitoringSettingsInternal)MonitoringSetting).AzureMonitorAlertSetting = value; }

        /// <summary>Internal Acessors for SecuritySetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.ISecuritySettings Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IPatchBackupVaultInputInternal.SecuritySetting { get => (this._securitySetting = this._securitySetting ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.SecuritySettings()); set { {_securitySetting = value;} } }

        /// <summary>Internal Acessors for SecuritySettingImmutabilitySetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IImmutabilitySettings Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IPatchBackupVaultInputInternal.SecuritySettingImmutabilitySetting { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.ISecuritySettingsInternal)SecuritySetting).ImmutabilitySetting; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.ISecuritySettingsInternal)SecuritySetting).ImmutabilitySetting = value; }

        /// <summary>Internal Acessors for SoftDeleteSetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.ISoftDeleteSettings Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IPatchBackupVaultInputInternal.SoftDeleteSetting { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.ISecuritySettingsInternal)SecuritySetting).SoftDeleteSetting; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.ISecuritySettingsInternal)SecuritySetting).SoftDeleteSetting = value; }

        /// <summary>Backing field for <see cref="MonitoringSetting" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IMonitoringSettings _monitoringSetting;

        /// <summary>Monitoring Settings</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IMonitoringSettings MonitoringSetting { get => (this._monitoringSetting = this._monitoringSetting ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.MonitoringSettings()); set => this._monitoringSetting = value; }

        /// <summary>Backing field for <see cref="ResourceGuardOperationRequest" /> property.</summary>
        private string[] _resourceGuardOperationRequest;

        /// <summary>ResourceGuardOperationRequests on which LAC check will be performed</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Owned)]
        public string[] ResourceGuardOperationRequest { get => this._resourceGuardOperationRequest; set => this._resourceGuardOperationRequest = value; }

        /// <summary>Backing field for <see cref="SecuritySetting" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.ISecuritySettings _securitySetting;

        /// <summary>Security Settings</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.ISecuritySettings SecuritySetting { get => (this._securitySetting = this._securitySetting ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.SecuritySettings()); set => this._securitySetting = value; }

        /// <summary>Soft delete retention duration</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public double? SoftDeleteRetentionDurationInDay { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.ISecuritySettingsInternal)SecuritySetting).SoftDeleteRetentionDurationInDay; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.ISecuritySettingsInternal)SecuritySetting).SoftDeleteRetentionDurationInDay = value ?? default(double); }

        /// <summary>State of soft delete</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.SoftDeleteState? SoftDeleteState { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.ISecuritySettingsInternal)SecuritySetting).SoftDeleteState; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.ISecuritySettingsInternal)SecuritySetting).SoftDeleteState = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.SoftDeleteState)""); }

        /// <summary>Creates an new <see cref="PatchBackupVaultInput" /> instance.</summary>
        public PatchBackupVaultInput()
        {

        }
    }
    /// Backup Vault Contract for Patch Backup Vault API.
    public partial interface IPatchBackupVaultInput :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.IJsonSerializable
    {
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"alertsForAllJobFailures",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.AlertsState) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.AlertsState? AzureMonitorAlertsForAllJobFailure { get; set; }
        /// <summary>CrossRegionRestore state</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"CrossRegionRestore state",
        SerializedName = @"state",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.CrossRegionRestoreState) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.CrossRegionRestoreState? CrossRegionRestoreState { get; set; }
        /// <summary>CrossSubscriptionRestore state</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"CrossSubscriptionRestore state",
        SerializedName = @"state",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.CrossSubscriptionRestoreState) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.CrossSubscriptionRestoreState? CrossSubscriptionRestoreState { get; set; }
        /// <summary>Customer Managed Key details of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Customer Managed Key details of the resource.",
        SerializedName = @"encryptionSettings",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IEncryptionSettings) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IEncryptionSettings EncryptionSetting { get; set; }
        /// <summary>Immutability state</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Immutability state",
        SerializedName = @"state",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.ImmutabilityState) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.ImmutabilityState? ImmutabilityState { get; set; }
        /// <summary>ResourceGuardOperationRequests on which LAC check will be performed</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"ResourceGuardOperationRequests on which LAC check will be performed",
        SerializedName = @"resourceGuardOperationRequests",
        PossibleTypes = new [] { typeof(string) })]
        string[] ResourceGuardOperationRequest { get; set; }
        /// <summary>Soft delete retention duration</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Soft delete retention duration",
        SerializedName = @"retentionDurationInDays",
        PossibleTypes = new [] { typeof(double) })]
        double? SoftDeleteRetentionDurationInDay { get; set; }
        /// <summary>State of soft delete</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"State of soft delete",
        SerializedName = @"state",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.SoftDeleteState) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.SoftDeleteState? SoftDeleteState { get; set; }

    }
    /// Backup Vault Contract for Patch Backup Vault API.
    internal partial interface IPatchBackupVaultInputInternal

    {
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.AlertsState? AzureMonitorAlertsForAllJobFailure { get; set; }
        /// <summary>CrossRegionRestore state</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.CrossRegionRestoreState? CrossRegionRestoreState { get; set; }
        /// <summary>CrossSubscriptionRestore state</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.CrossSubscriptionRestoreState? CrossSubscriptionRestoreState { get; set; }
        /// <summary>Customer Managed Key details of the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IEncryptionSettings EncryptionSetting { get; set; }
        /// <summary>Feature Settings</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IFeatureSettings FeatureSetting { get; set; }

        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.ICrossRegionRestoreSettings FeatureSettingCrossRegionRestoreSetting { get; set; }
        /// <summary>CrossSubscriptionRestore Settings</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.ICrossSubscriptionRestoreSettings FeatureSettingCrossSubscriptionRestoreSetting { get; set; }
        /// <summary>Immutability state</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.ImmutabilityState? ImmutabilityState { get; set; }
        /// <summary>Monitoring Settings</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IMonitoringSettings MonitoringSetting { get; set; }
        /// <summary>Settings for Azure Monitor based alerts</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IAzureMonitorAlertSettings MonitoringSettingAzureMonitorAlertSetting { get; set; }
        /// <summary>ResourceGuardOperationRequests on which LAC check will be performed</summary>
        string[] ResourceGuardOperationRequest { get; set; }
        /// <summary>Security Settings</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.ISecuritySettings SecuritySetting { get; set; }
        /// <summary>Immutability Settings at vault level</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IImmutabilitySettings SecuritySettingImmutabilitySetting { get; set; }
        /// <summary>Soft delete retention duration</summary>
        double? SoftDeleteRetentionDurationInDay { get; set; }
        /// <summary>Soft delete related settings</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.ISoftDeleteSettings SoftDeleteSetting { get; set; }
        /// <summary>State of soft delete</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.SoftDeleteState? SoftDeleteState { get; set; }

    }
}