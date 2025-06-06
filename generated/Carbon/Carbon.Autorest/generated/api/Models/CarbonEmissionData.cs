// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Carbon.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Carbon.Runtime.Extensions;

    /// <summary>
    /// The basic response for different query report, all query report result will have these information
    /// </summary>
    [Microsoft.Azure.PowerShell.Cmdlets.Carbon.DoNotFormat]
    public partial class CarbonEmissionData :
        Microsoft.Azure.PowerShell.Cmdlets.Carbon.Models.ICarbonEmissionData,
        Microsoft.Azure.PowerShell.Cmdlets.Carbon.Models.ICarbonEmissionDataInternal
    {

        /// <summary>Backing field for <see cref="DataType" /> property.</summary>
        private string _dataType;

        /// <summary>
        /// The data type of the query result, indicating the format of the returned response.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Carbon.Origin(Microsoft.Azure.PowerShell.Cmdlets.Carbon.PropertyOrigin.Owned)]
        public string DataType { get => this._dataType; set => this._dataType = value; }

        /// <summary>Backing field for <see cref="LatestMonthEmission" /> property.</summary>
        private double _latestMonthEmission;

        /// <summary>
        /// Total carbon emissions for the specified query parameters, measured in kgCO2E. This value represents total emissions over
        /// the specified date range (e.g., March-June).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Carbon.Origin(Microsoft.Azure.PowerShell.Cmdlets.Carbon.PropertyOrigin.Owned)]
        public double LatestMonthEmission { get => this._latestMonthEmission; set => this._latestMonthEmission = value; }

        /// <summary>Backing field for <see cref="MonthOverMonthEmissionsChangeRatio" /> property.</summary>
        private double? _monthOverMonthEmissionsChangeRatio;

        /// <summary>
        /// The percentage change in carbon emissions between the current and previous DateRange. This is calculated as: (latestMonthEmissions
        /// - previousMonthEmissions) / previousMonthEmissions.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Carbon.Origin(Microsoft.Azure.PowerShell.Cmdlets.Carbon.PropertyOrigin.Owned)]
        public double? MonthOverMonthEmissionsChangeRatio { get => this._monthOverMonthEmissionsChangeRatio; set => this._monthOverMonthEmissionsChangeRatio = value; }

        /// <summary>Backing field for <see cref="MonthlyEmissionsChangeValue" /> property.</summary>
        private double? _monthlyEmissionsChangeValue;

        /// <summary>
        /// The change in carbon emissions between the current and previous period, calculated as: latestMonthEmissions - previousMonthEmissions.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Carbon.Origin(Microsoft.Azure.PowerShell.Cmdlets.Carbon.PropertyOrigin.Owned)]
        public double? MonthlyEmissionsChangeValue { get => this._monthlyEmissionsChangeValue; set => this._monthlyEmissionsChangeValue = value; }

        /// <summary>Backing field for <see cref="PreviousMonthEmission" /> property.</summary>
        private double _previousMonthEmission;

        /// <summary>
        /// Total carbon emissions for the previous month’s date range, which is the same period as the specified date range but shifted
        /// left by one month (e.g., if the specified range is March - June, the previous month’s range will be Feb - May). The value
        /// is measured in kgCO2E.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Carbon.Origin(Microsoft.Azure.PowerShell.Cmdlets.Carbon.PropertyOrigin.Owned)]
        public double PreviousMonthEmission { get => this._previousMonthEmission; set => this._previousMonthEmission = value; }

        /// <summary>Creates an new <see cref="CarbonEmissionData" /> instance.</summary>
        public CarbonEmissionData()
        {

        }
    }
    /// The basic response for different query report, all query report result will have these information
    public partial interface ICarbonEmissionData :
        Microsoft.Azure.PowerShell.Cmdlets.Carbon.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The data type of the query result, indicating the format of the returned response.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Carbon.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The data type of the query result, indicating the format of the returned response.",
        SerializedName = @"dataType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Carbon.PSArgumentCompleterAttribute("OverallSummaryData", "MonthlySummaryData", "TopItemsSummaryData", "ResourceTopItemsSummaryData", "ResourceGroupTopItemsSummaryData", "TopItemsMonthlySummaryData", "ResourceTopItemsMonthlySummaryData", "ResourceGroupTopItemsMonthlySummaryData", "ItemDetailsData", "ResourceItemDetailsData", "ResourceGroupItemDetailsData")]
        string DataType { get; set; }
        /// <summary>
        /// Total carbon emissions for the specified query parameters, measured in kgCO2E. This value represents total emissions over
        /// the specified date range (e.g., March-June).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Carbon.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Total carbon emissions for the specified query parameters, measured in kgCO2E. This value represents total emissions over the specified date range (e.g., March-June).",
        SerializedName = @"latestMonthEmissions",
        PossibleTypes = new [] { typeof(double) })]
        double LatestMonthEmission { get; set; }
        /// <summary>
        /// The percentage change in carbon emissions between the current and previous DateRange. This is calculated as: (latestMonthEmissions
        /// - previousMonthEmissions) / previousMonthEmissions.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Carbon.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The percentage change in carbon emissions between the current and previous DateRange. This is calculated as: (latestMonthEmissions - previousMonthEmissions) / previousMonthEmissions.",
        SerializedName = @"monthOverMonthEmissionsChangeRatio",
        PossibleTypes = new [] { typeof(double) })]
        double? MonthOverMonthEmissionsChangeRatio { get; set; }
        /// <summary>
        /// The change in carbon emissions between the current and previous period, calculated as: latestMonthEmissions - previousMonthEmissions.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Carbon.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The change in carbon emissions between the current and previous period, calculated as: latestMonthEmissions - previousMonthEmissions.",
        SerializedName = @"monthlyEmissionsChangeValue",
        PossibleTypes = new [] { typeof(double) })]
        double? MonthlyEmissionsChangeValue { get; set; }
        /// <summary>
        /// Total carbon emissions for the previous month’s date range, which is the same period as the specified date range but shifted
        /// left by one month (e.g., if the specified range is March - June, the previous month’s range will be Feb - May). The value
        /// is measured in kgCO2E.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Carbon.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Total carbon emissions for the previous month’s date range, which is the same period as the specified date range but shifted left by one month (e.g., if the specified range is March - June, the previous month’s range will be Feb - May). The value is measured in kgCO2E.",
        SerializedName = @"previousMonthEmissions",
        PossibleTypes = new [] { typeof(double) })]
        double PreviousMonthEmission { get; set; }

    }
    /// The basic response for different query report, all query report result will have these information
    internal partial interface ICarbonEmissionDataInternal

    {
        /// <summary>
        /// The data type of the query result, indicating the format of the returned response.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Carbon.PSArgumentCompleterAttribute("OverallSummaryData", "MonthlySummaryData", "TopItemsSummaryData", "ResourceTopItemsSummaryData", "ResourceGroupTopItemsSummaryData", "TopItemsMonthlySummaryData", "ResourceTopItemsMonthlySummaryData", "ResourceGroupTopItemsMonthlySummaryData", "ItemDetailsData", "ResourceItemDetailsData", "ResourceGroupItemDetailsData")]
        string DataType { get; set; }
        /// <summary>
        /// Total carbon emissions for the specified query parameters, measured in kgCO2E. This value represents total emissions over
        /// the specified date range (e.g., March-June).
        /// </summary>
        double LatestMonthEmission { get; set; }
        /// <summary>
        /// The percentage change in carbon emissions between the current and previous DateRange. This is calculated as: (latestMonthEmissions
        /// - previousMonthEmissions) / previousMonthEmissions.
        /// </summary>
        double? MonthOverMonthEmissionsChangeRatio { get; set; }
        /// <summary>
        /// The change in carbon emissions between the current and previous period, calculated as: latestMonthEmissions - previousMonthEmissions.
        /// </summary>
        double? MonthlyEmissionsChangeValue { get; set; }
        /// <summary>
        /// Total carbon emissions for the previous month’s date range, which is the same period as the specified date range but shifted
        /// left by one month (e.g., if the specified range is March - June, the previous month’s range will be Feb - May). The value
        /// is measured in kgCO2E.
        /// </summary>
        double PreviousMonthEmission { get; set; }

    }
}