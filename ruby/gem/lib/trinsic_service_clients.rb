require 'generated/credentials'
require 'generated/wallet'
require 'generated/provider'
require 'ms_rest'

module TrinsicServiceClients
  include Credentials
  include Wallet
  include Provider
  include MsRest

  NoRetryPolicy = { middlewares: [[MsRest::RetryPolicyMiddleware, times: 0, retry: 0], [:cookie_jar]] }
end
