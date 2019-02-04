// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Streetcred.Cloud.Client
{
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for CloudServiceClient.
    /// </summary>
    public static partial class CloudServiceClientExtensions
    {
            /// <summary>
            /// Accepts the invitation.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='xStreetcredWalletId'>
            /// Identifier of the cloud wallet used with this request.
            /// </param>
            /// <param name='invitation'>
            /// The invitation.
            /// </param>
            public static ObjectId AcceptInvitation(this ICloudServiceClient operations, string xStreetcredWalletId, ConnectionInvitationMessage invitation = default(ConnectionInvitationMessage))
            {
                return operations.AcceptInvitationAsync(xStreetcredWalletId, invitation).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Accepts the invitation.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='xStreetcredWalletId'>
            /// Identifier of the cloud wallet used with this request.
            /// </param>
            /// <param name='invitation'>
            /// The invitation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ObjectId> AcceptInvitationAsync(this ICloudServiceClient operations, string xStreetcredWalletId, ConnectionInvitationMessage invitation = default(ConnectionInvitationMessage), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.AcceptInvitationWithHttpMessagesAsync(xStreetcredWalletId, invitation, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates the connections.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='connectionId'>
            /// The connection identifier.
            /// </param>
            /// <param name='xStreetcredWalletId'>
            /// Identifier of the cloud wallet used with this request.
            /// </param>
            public static ConnectionInfo GetConnection(this ICloudServiceClient operations, string connectionId, string xStreetcredWalletId)
            {
                return operations.GetConnectionAsync(connectionId, xStreetcredWalletId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates the connections.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='connectionId'>
            /// The connection identifier.
            /// </param>
            /// <param name='xStreetcredWalletId'>
            /// Identifier of the cloud wallet used with this request.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ConnectionInfo> GetConnectionAsync(this ICloudServiceClient operations, string connectionId, string xStreetcredWalletId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetConnectionWithHttpMessagesAsync(connectionId, xStreetcredWalletId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the connections.
            /// </summary>
            /// <remarks>
            /// Retrieves a list of connections that are in 'Connected' state.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='xStreetcredWalletId'>
            /// Identifier of the cloud wallet used with this request.
            /// </param>
            public static IList<ConnectionInfo> GetConnections(this ICloudServiceClient operations, string xStreetcredWalletId)
            {
                return operations.GetConnectionsAsync(xStreetcredWalletId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the connections.
            /// </summary>
            /// <remarks>
            /// Retrieves a list of connections that are in 'Connected' state.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='xStreetcredWalletId'>
            /// Identifier of the cloud wallet used with this request.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<ConnectionInfo>> GetConnectionsAsync(this ICloudServiceClient operations, string xStreetcredWalletId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetConnectionsWithHttpMessagesAsync(xStreetcredWalletId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the invitations.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='xStreetcredWalletId'>
            /// Identifier of the cloud wallet used with this request.
            /// </param>
            public static IList<ConnectionInfo> GetInvitations(this ICloudServiceClient operations, string xStreetcredWalletId)
            {
                return operations.GetInvitationsAsync(xStreetcredWalletId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the invitations.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='xStreetcredWalletId'>
            /// Identifier of the cloud wallet used with this request.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<ConnectionInfo>> GetInvitationsAsync(this ICloudServiceClient operations, string xStreetcredWalletId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetInvitationsWithHttpMessagesAsync(xStreetcredWalletId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='connectionId'>
            /// </param>
            /// <param name='xStreetcredWalletId'>
            /// Identifier of the cloud wallet used with this request.
            /// </param>
            public static IList<CredentialInfo> ListCredentialsForConnectionId(this ICloudServiceClient operations, string connectionId, string xStreetcredWalletId)
            {
                return operations.ListCredentialsForConnectionIdAsync(connectionId, xStreetcredWalletId).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='connectionId'>
            /// </param>
            /// <param name='xStreetcredWalletId'>
            /// Identifier of the cloud wallet used with this request.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<CredentialInfo>> ListCredentialsForConnectionIdAsync(this ICloudServiceClient operations, string connectionId, string xStreetcredWalletId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListCredentialsForConnectionIdWithHttpMessagesAsync(connectionId, xStreetcredWalletId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='xStreetcredWalletId'>
            /// Identifier of the cloud wallet used with this request.
            /// </param>
            public static IList<CredentialInfo> ListCredentials(this ICloudServiceClient operations, string xStreetcredWalletId)
            {
                return operations.ListCredentialsAsync(xStreetcredWalletId).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='xStreetcredWalletId'>
            /// Identifier of the cloud wallet used with this request.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<CredentialInfo>> ListCredentialsAsync(this ICloudServiceClient operations, string xStreetcredWalletId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListCredentialsWithHttpMessagesAsync(xStreetcredWalletId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='credentialId'>
            /// </param>
            /// <param name='xStreetcredWalletId'>
            /// Identifier of the cloud wallet used with this request.
            /// </param>
            public static void AcceptCredentialOffer(this ICloudServiceClient operations, string credentialId, string xStreetcredWalletId)
            {
                operations.AcceptCredentialOfferAsync(credentialId, xStreetcredWalletId).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='credentialId'>
            /// </param>
            /// <param name='xStreetcredWalletId'>
            /// Identifier of the cloud wallet used with this request.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task AcceptCredentialOfferAsync(this ICloudServiceClient operations, string credentialId, string xStreetcredWalletId, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.AcceptCredentialOfferWithHttpMessagesAsync(credentialId, xStreetcredWalletId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Associates the destination.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='xStreetcredWalletId'>
            /// Identifier of the cloud wallet used with this request.
            /// </param>
            /// <param name='destinationRegistration'>
            /// The delivery registration.
            /// </param>
            public static void AssociateDestination(this ICloudServiceClient operations, string xStreetcredWalletId, DestinationRegistration destinationRegistration = default(DestinationRegistration))
            {
                operations.AssociateDestinationAsync(xStreetcredWalletId, destinationRegistration).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Associates the destination.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='xStreetcredWalletId'>
            /// Identifier of the cloud wallet used with this request.
            /// </param>
            /// <param name='destinationRegistration'>
            /// The delivery registration.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task AssociateDestinationAsync(this ICloudServiceClient operations, string xStreetcredWalletId, DestinationRegistration destinationRegistration = default(DestinationRegistration), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.AssociateDestinationWithHttpMessagesAsync(xStreetcredWalletId, destinationRegistration, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Registers the push.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='xStreetcredWalletId'>
            /// Identifier of the cloud wallet used with this request.
            /// </param>
            /// <param name='deviceRegistration'>
            /// The device registration.
            /// </param>
            public static void RegisterPush(this ICloudServiceClient operations, string xStreetcredWalletId, DeviceRegistration deviceRegistration = default(DeviceRegistration))
            {
                operations.RegisterPushAsync(xStreetcredWalletId, deviceRegistration).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Registers the push.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='xStreetcredWalletId'>
            /// Identifier of the cloud wallet used with this request.
            /// </param>
            /// <param name='deviceRegistration'>
            /// The device registration.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task RegisterPushAsync(this ICloudServiceClient operations, string xStreetcredWalletId, DeviceRegistration deviceRegistration = default(DeviceRegistration), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.RegisterPushWithHttpMessagesAsync(xStreetcredWalletId, deviceRegistration, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Returns the agent configuration
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static ProvisioningInfo GetConfiguration(this ICloudServiceClient operations)
            {
                return operations.GetConfigurationAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns the agent configuration
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ProvisioningInfo> GetConfigurationAsync(this ICloudServiceClient operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetConfigurationWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Retreives the messages.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='xStreetcredWalletId'>
            /// Identifier of the cloud wallet used with this request.
            /// </param>
            public static IList<string> RetreiveMessages(this ICloudServiceClient operations, string xStreetcredWalletId)
            {
                return operations.RetreiveMessagesAsync(xStreetcredWalletId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retreives the messages.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='xStreetcredWalletId'>
            /// Identifier of the cloud wallet used with this request.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<string>> RetreiveMessagesAsync(this ICloudServiceClient operations, string xStreetcredWalletId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.RetreiveMessagesWithHttpMessagesAsync(xStreetcredWalletId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the messages.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='xStreetcredWalletId'>
            /// Identifier of the cloud wallet used with this request.
            /// </param>
            /// <param name='messageIds'>
            /// The message ids.
            /// </param>
            public static void DeleteMessages(this ICloudServiceClient operations, string xStreetcredWalletId, IList<string> messageIds = default(IList<string>))
            {
                operations.DeleteMessagesAsync(xStreetcredWalletId, messageIds).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the messages.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='xStreetcredWalletId'>
            /// Identifier of the cloud wallet used with this request.
            /// </param>
            /// <param name='messageIds'>
            /// The message ids.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteMessagesAsync(this ICloudServiceClient operations, string xStreetcredWalletId, IList<string> messageIds = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteMessagesWithHttpMessagesAsync(xStreetcredWalletId, messageIds, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Lists the wallets async.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IList<WalletInfo> ListWallets(this ICloudServiceClient operations)
            {
                return operations.ListWalletsAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the wallets async.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<WalletInfo>> ListWalletsAsync(this ICloudServiceClient operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWalletsWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create new wallet.
            /// </summary>
            /// <remarks>
            /// These are remarks.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='walletInfo'>
            /// The wallet information.
            /// </param>
            public static ObjectId CreateWallet(this ICloudServiceClient operations, WalletInfo walletInfo = default(WalletInfo))
            {
                return operations.CreateWalletAsync(walletInfo).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create new wallet.
            /// </summary>
            /// <remarks>
            /// These are remarks.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='walletInfo'>
            /// The wallet information.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ObjectId> CreateWalletAsync(this ICloudServiceClient operations, WalletInfo walletInfo = default(WalletInfo), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWalletWithHttpMessagesAsync(walletInfo, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the wallet async.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='xStreetcredWalletId'>
            /// Identifier of the cloud wallet used with this request.
            /// </param>
            public static void DeleteWallet(this ICloudServiceClient operations, string xStreetcredWalletId)
            {
                operations.DeleteWalletAsync(xStreetcredWalletId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the wallet async.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='xStreetcredWalletId'>
            /// Identifier of the cloud wallet used with this request.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteWalletAsync(this ICloudServiceClient operations, string xStreetcredWalletId, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWalletWithHttpMessagesAsync(xStreetcredWalletId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}
