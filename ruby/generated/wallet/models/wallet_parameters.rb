# encoding: utf-8
# Code generated by Microsoft (R) AutoRest Code Generator.
# Changes may cause incorrect behavior and will be lost if the code is
# regenerated.

module Wallet
  module Models
    #
    # Wallet parameters
    #
    class WalletParameters
      # @return [String] The wallet identifier
      # <remarks>
      # This property can be null. If not set, a unique identifier will be
      # generated
      # </remarks>
      attr_accessor :wallet_id

      # @return [String] The owner name
      attr_accessor :owner_name


      #
      # Mapper for WalletParameters class as Ruby Hash.
      # This will be used for serialization/deserialization.
      #
      def self.mapper()
        {
          client_side_validation: true,
          required: false,
          serialized_name: 'WalletParameters',
          type: {
            name: 'Composite',
            class_name: 'WalletParameters',
            model_properties: {
              wallet_id: {
                client_side_validation: true,
                required: false,
                serialized_name: 'walletId',
                type: {
                  name: 'String'
                }
              },
              owner_name: {
                client_side_validation: true,
                required: false,
                serialized_name: 'ownerName',
                type: {
                  name: 'String'
                }
              }
            }
          }
        }
      end
    end
  end
end
