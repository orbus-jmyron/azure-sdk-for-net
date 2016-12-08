// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network
{
    using Azure;
    using Management;
    using Rest;
    using Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for PublicIPAddressesOperations.
    /// </summary>
    public static partial class PublicIPAddressesOperationsExtensions
    {
            /// <summary>
            /// Deletes the specified public IP address.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='publicIpAddressName'>
            /// The name of the subnet.
            /// </param>
            public static void Delete(this IPublicIPAddressesOperations operations, string resourceGroupName, string publicIpAddressName)
            {
                Task.Factory.StartNew(s => ((IPublicIPAddressesOperations)s).DeleteAsync(resourceGroupName, publicIpAddressName), operations, CancellationToken.None, TaskCreationOptions.None,  TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the specified public IP address.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='publicIpAddressName'>
            /// The name of the subnet.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IPublicIPAddressesOperations operations, string resourceGroupName, string publicIpAddressName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.DeleteWithHttpMessagesAsync(resourceGroupName, publicIpAddressName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Gets the specified public IP address in a specified resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='publicIpAddressName'>
            /// The name of the subnet.
            /// </param>
            /// <param name='expand'>
            /// Expands referenced resources.
            /// </param>
            public static PublicIPAddress Get(this IPublicIPAddressesOperations operations, string resourceGroupName, string publicIpAddressName, string expand = default(string))
            {
                return Task.Factory.StartNew(s => ((IPublicIPAddressesOperations)s).GetAsync(resourceGroupName, publicIpAddressName, expand), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the specified public IP address in a specified resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='publicIpAddressName'>
            /// The name of the subnet.
            /// </param>
            /// <param name='expand'>
            /// Expands referenced resources.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PublicIPAddress> GetAsync(this IPublicIPAddressesOperations operations, string resourceGroupName, string publicIpAddressName, string expand = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, publicIpAddressName, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates a static or dynamic public IP address.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='publicIpAddressName'>
            /// The name of the public IP address.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create or update public IP address operation.
            /// </param>
            public static PublicIPAddress CreateOrUpdate(this IPublicIPAddressesOperations operations, string resourceGroupName, string publicIpAddressName, PublicIPAddress parameters)
            {
                return Task.Factory.StartNew(s => ((IPublicIPAddressesOperations)s).CreateOrUpdateAsync(resourceGroupName, publicIpAddressName, parameters), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a static or dynamic public IP address.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='publicIpAddressName'>
            /// The name of the public IP address.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create or update public IP address operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PublicIPAddress> CreateOrUpdateAsync(this IPublicIPAddressesOperations operations, string resourceGroupName, string publicIpAddressName, PublicIPAddress parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, publicIpAddressName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all the public IP addresses in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IPage<PublicIPAddress> ListAll(this IPublicIPAddressesOperations operations)
            {
                return Task.Factory.StartNew(s => ((IPublicIPAddressesOperations)s).ListAllAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all the public IP addresses in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<PublicIPAddress>> ListAllAsync(this IPublicIPAddressesOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListAllWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all public IP addresses in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            public static IPage<PublicIPAddress> List(this IPublicIPAddressesOperations operations, string resourceGroupName)
            {
                return Task.Factory.StartNew(s => ((IPublicIPAddressesOperations)s).ListAsync(resourceGroupName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all public IP addresses in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<PublicIPAddress>> ListAsync(this IPublicIPAddressesOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the specified public IP address.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='publicIpAddressName'>
            /// The name of the subnet.
            /// </param>
            public static void BeginDelete(this IPublicIPAddressesOperations operations, string resourceGroupName, string publicIpAddressName)
            {
                Task.Factory.StartNew(s => ((IPublicIPAddressesOperations)s).BeginDeleteAsync(resourceGroupName, publicIpAddressName), operations, CancellationToken.None, TaskCreationOptions.None,  TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the specified public IP address.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='publicIpAddressName'>
            /// The name of the subnet.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IPublicIPAddressesOperations operations, string resourceGroupName, string publicIpAddressName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, publicIpAddressName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Creates or updates a static or dynamic public IP address.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='publicIpAddressName'>
            /// The name of the public IP address.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create or update public IP address operation.
            /// </param>
            public static PublicIPAddress BeginCreateOrUpdate(this IPublicIPAddressesOperations operations, string resourceGroupName, string publicIpAddressName, PublicIPAddress parameters)
            {
                return Task.Factory.StartNew(s => ((IPublicIPAddressesOperations)s).BeginCreateOrUpdateAsync(resourceGroupName, publicIpAddressName, parameters), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a static or dynamic public IP address.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='publicIpAddressName'>
            /// The name of the public IP address.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create or update public IP address operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PublicIPAddress> BeginCreateOrUpdateAsync(this IPublicIPAddressesOperations operations, string resourceGroupName, string publicIpAddressName, PublicIPAddress parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, publicIpAddressName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all the public IP addresses in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<PublicIPAddress> ListAllNext(this IPublicIPAddressesOperations operations, string nextPageLink)
            {
                return Task.Factory.StartNew(s => ((IPublicIPAddressesOperations)s).ListAllNextAsync(nextPageLink), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all the public IP addresses in a subscription.
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
            public static async Task<IPage<PublicIPAddress>> ListAllNextAsync(this IPublicIPAddressesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListAllNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all public IP addresses in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<PublicIPAddress> ListNext(this IPublicIPAddressesOperations operations, string nextPageLink)
            {
                return Task.Factory.StartNew(s => ((IPublicIPAddressesOperations)s).ListNextAsync(nextPageLink), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all public IP addresses in a resource group.
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
            public static async Task<IPage<PublicIPAddress>> ListNextAsync(this IPublicIPAddressesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}

