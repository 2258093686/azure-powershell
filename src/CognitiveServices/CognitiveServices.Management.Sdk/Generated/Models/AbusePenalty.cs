// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.CognitiveServices.Models
{
    using System.Linq;

    /// <summary>
    /// The abuse penalty.
    /// </summary>
    public partial class AbusePenalty
    {
        /// <summary>
        /// Initializes a new instance of the AbusePenalty class.
        /// </summary>
        public AbusePenalty()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AbusePenalty class.
        /// </summary>

        /// <param name="action">The action of AbusePenalty.
        /// Possible values include: &#39;Throttle&#39;, &#39;Block&#39;</param>

        /// <param name="rateLimitPercentage">The percentage of rate limit.
        /// </param>

        /// <param name="expiration">The datetime of expiration of the AbusePenalty.
        /// </param>
        public AbusePenalty(string action = default(string), double? rateLimitPercentage = default(double?), System.DateTime? expiration = default(System.DateTime?))

        {
            this.Action = action;
            this.RateLimitPercentage = rateLimitPercentage;
            this.Expiration = expiration;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the action of AbusePenalty. Possible values include: &#39;Throttle&#39;, &#39;Block&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "action")]
        public string Action {get; set; }

        /// <summary>
        /// Gets or sets the percentage of rate limit.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "rateLimitPercentage")]
        public double? RateLimitPercentage {get; set; }

        /// <summary>
        /// Gets or sets the datetime of expiration of the AbusePenalty.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "expiration")]
        public System.DateTime? Expiration {get; set; }
    }
}