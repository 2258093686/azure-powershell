// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Websites.Helper.Network
{
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// Extension methods for VirtualNetworksOperations
    /// </summary>
    public static partial class VirtualNetworksOperationsExtensions
    {
        /// <summary>
        /// Gets all virtual networks in a subscription.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        public static Microsoft.Rest.Azure.IPage<VirtualNetwork> ListAll(this IVirtualNetworksOperations operations)
        {
                return ((IVirtualNetworksOperations)operations).ListAllAsync().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Gets all virtual networks in a subscription.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Microsoft.Rest.Azure.IPage<VirtualNetwork>> ListAllAsync(this IVirtualNetworksOperations operations, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ListAllWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Gets all virtual networks in a subscription.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        public static Microsoft.Rest.Azure.IPage<VirtualNetwork> ListAllNext(this IVirtualNetworksOperations operations, string nextPageLink)
        {
                return ((IVirtualNetworksOperations)operations).ListAllNextAsync(nextPageLink).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Gets all virtual networks in a subscription.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Microsoft.Rest.Azure.IPage<VirtualNetwork>> ListAllNextAsync(this IVirtualNetworksOperations operations, string nextPageLink, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ListAllNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
    }
}
