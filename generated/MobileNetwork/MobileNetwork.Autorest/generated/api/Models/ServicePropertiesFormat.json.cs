// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Extensions;

    /// <summary>Service properties.</summary>
    public partial class ServicePropertiesFormat
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name= "returnNow" />
        /// output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.IServicePropertiesFormat.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.IServicePropertiesFormat.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.IServicePropertiesFormat FromJson(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonObject json ? new ServicePropertiesFormat(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonObject into a new instance of <see cref="ServicePropertiesFormat" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal ServicePropertiesFormat(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_serviceQosPolicy = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonObject>("serviceQosPolicy"), out var __jsonServiceQosPolicy) ? Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.QosPolicy.FromJson(__jsonServiceQosPolicy) : _serviceQosPolicy;}
            {_provisioningState = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonString>("provisioningState"), out var __jsonProvisioningState) ? (string)__jsonProvisioningState : (string)_provisioningState;}
            {_servicePrecedence = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonNumber>("servicePrecedence"), out var __jsonServicePrecedence) ? (int)__jsonServicePrecedence : _servicePrecedence;}
            {_pccRule = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonArray>("pccRules"), out var __jsonPccRules) ? If( __jsonPccRules as Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.IPccRuleConfiguration>>(()=> global::System.Linq.Enumerable.ToList(global::System.Linq.Enumerable.Select(__v, (__u)=>(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.IPccRuleConfiguration) (Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.PccRuleConfiguration.FromJson(__u) )) ))() : null : _pccRule;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="ServicePropertiesFormat" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="ServicePropertiesFormat" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != this._serviceQosPolicy ? (Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonNode) this._serviceQosPolicy.ToJson(null,serializationMode) : null, "serviceQosPolicy" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._provisioningState)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonString(this._provisioningState.ToString()) : null, "provisioningState" ,container.Add );
            }
            AddIf( (Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonNumber(this._servicePrecedence), "servicePrecedence" ,container.Add );
            if (null != this._pccRule)
            {
                var __w = new Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.XNodeArray();
                foreach( var __x in this._pccRule )
                {
                    AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                }
                container.Add("pccRules",__w);
            }
            AfterToJson(ref container);
            return container;
        }
    }
}