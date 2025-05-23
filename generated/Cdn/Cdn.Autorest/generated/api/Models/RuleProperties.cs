// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Extensions;

    /// <summary>The JSON object that contains the properties of the Rules to create.</summary>
    public partial class RuleProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IRuleProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IRulePropertiesInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdStateProperties" />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdStateProperties __afdStateProperties = new Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.AfdStateProperties();

        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IRuleUpdatePropertiesParameters"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IRuleUpdatePropertiesParameters __ruleUpdatePropertiesParameters = new Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.RuleUpdatePropertiesParameters();

        /// <summary>
        /// A list of actions that are executed when all the conditions of a rule are satisfied.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inherited)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IDeliveryRuleAction> Action { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IRuleUpdatePropertiesParametersInternal)__ruleUpdatePropertiesParameters).Action; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IRuleUpdatePropertiesParametersInternal)__ruleUpdatePropertiesParameters).Action = value ?? null /* arrayOf */; }

        /// <summary>A list of conditions that must be matched for the actions to be executed</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inherited)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IDeliveryRuleCondition> Condition { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IRuleUpdatePropertiesParametersInternal)__ruleUpdatePropertiesParameters).Condition; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IRuleUpdatePropertiesParametersInternal)__ruleUpdatePropertiesParameters).Condition = value ?? null /* arrayOf */; }

        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inherited)]
        public string DeploymentStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdStatePropertiesInternal)__afdStateProperties).DeploymentStatus; }

        /// <summary>
        /// If this rule is a match should the rules engine continue running the remaining rules or stop. If not present, defaults
        /// to Continue.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inherited)]
        public string MatchProcessingBehavior { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IRuleUpdatePropertiesParametersInternal)__ruleUpdatePropertiesParameters).MatchProcessingBehavior; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IRuleUpdatePropertiesParametersInternal)__ruleUpdatePropertiesParameters).MatchProcessingBehavior = value ?? null; }

        /// <summary>Internal Acessors for DeploymentStatus</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdStatePropertiesInternal.DeploymentStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdStatePropertiesInternal)__afdStateProperties).DeploymentStatus; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdStatePropertiesInternal)__afdStateProperties).DeploymentStatus = value; }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdStatePropertiesInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdStatePropertiesInternal)__afdStateProperties).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdStatePropertiesInternal)__afdStateProperties).ProvisioningState = value; }

        /// <summary>Internal Acessors for RuleSetName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IRuleUpdatePropertiesParametersInternal.RuleSetName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IRuleUpdatePropertiesParametersInternal)__ruleUpdatePropertiesParameters).RuleSetName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IRuleUpdatePropertiesParametersInternal)__ruleUpdatePropertiesParameters).RuleSetName = value; }

        /// <summary>
        /// The order in which the rules are applied for the endpoint. Possible values {0,1,2,3,………}. A rule with a lesser order will
        /// be applied before a rule with a greater order. Rule with order 0 is a special rule. It does not require any condition
        /// and actions listed in it will always be applied.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inherited)]
        public int? Order { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IRuleUpdatePropertiesParametersInternal)__ruleUpdatePropertiesParameters).Order; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IRuleUpdatePropertiesParametersInternal)__ruleUpdatePropertiesParameters).Order = value ?? default(int); }

        /// <summary>Provisioning status</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inherited)]
        public string ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdStatePropertiesInternal)__afdStateProperties).ProvisioningState; }

        /// <summary>The name of the rule set containing the rule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inherited)]
        public string RuleSetName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IRuleUpdatePropertiesParametersInternal)__ruleUpdatePropertiesParameters).RuleSetName; }

        /// <summary>Creates an new <see cref="RuleProperties" /> instance.</summary>
        public RuleProperties()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__ruleUpdatePropertiesParameters), __ruleUpdatePropertiesParameters);
            await eventListener.AssertObjectIsValid(nameof(__ruleUpdatePropertiesParameters), __ruleUpdatePropertiesParameters);
            await eventListener.AssertNotNull(nameof(__afdStateProperties), __afdStateProperties);
            await eventListener.AssertObjectIsValid(nameof(__afdStateProperties), __afdStateProperties);
        }
    }
    /// The JSON object that contains the properties of the Rules to create.
    public partial interface IRuleProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IRuleUpdatePropertiesParameters,
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdStateProperties
    {

    }
    /// The JSON object that contains the properties of the Rules to create.
    internal partial interface IRulePropertiesInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IRuleUpdatePropertiesParametersInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdStatePropertiesInternal
    {

    }
}