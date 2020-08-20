require 'trinsic_service_clients/credentials'
require 'trinsic_service_clients/wallet'
require 'trinsic_service_clients/provider'

module TrinsicServiceClients
  autoload :Credentials,                                        'trinsic_service_clients/credentials'
  autoload :Wallet,                                             'trinsic_service_clients/wallet'
  autoload :Provider,                                           'trinsic_service_clients/provider'
  autoload :CredentialsClient,                                  'trinsic_service_clients/credentials/credentials_client'
  autoload :WalletClient,                                       'trinsic_service_clients/wallet/wallet_client'
  autoload :ProviderClient,                                     'trinsic_service_clients/provider/provider_client'
end
