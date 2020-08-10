# encoding: utf-8
# Code generated by Microsoft (R) AutoRest Code Generator.
# Changes may cause incorrect behavior and will be lost if the code is
# regenerated.

module Credentials
  module Models
    #
    # Configuration options for creating new tenant
    #
    class TenantParameters
      # @return [String] Issuer seed used for deterministic DID generation.
      # If omitted, a random DID/Key is generated.
      attr_accessor :issuer_seed

      # @return [String] The tenant name
      attr_accessor :name

      # @return [String] URL of tenant profile image
      attr_accessor :image_url

      # @return [String] Ledger network identifier.
      # Default is Sovrin Staging (sovrin-staging).
      attr_accessor :network_id

      # @return [Enum] Possible values include: 'Shared', 'Dedicated',
      # 'Delegated'
      attr_accessor :endorser_type


      #
      # Mapper for TenantParameters class as Ruby Hash.
      # This will be used for serialization/deserialization.
      #
      def self.mapper()
        {
          client_side_validation: true,
          required: false,
          serialized_name: 'TenantParameters',
          type: {
            name: 'Composite',
            class_name: 'TenantParameters',
            model_properties: {
              issuer_seed: {
                client_side_validation: true,
                required: false,
                serialized_name: 'issuerSeed',
                type: {
                  name: 'String'
                }
              },
              name: {
                client_side_validation: true,
                required: true,
                serialized_name: 'name',
                type: {
                  name: 'String'
                }
              },
              image_url: {
                client_side_validation: true,
                required: false,
                serialized_name: 'imageUrl',
                type: {
                  name: 'String'
                }
              },
              network_id: {
                client_side_validation: true,
                required: false,
                serialized_name: 'networkId',
                type: {
                  name: 'String'
                }
              },
              endorser_type: {
                client_side_validation: true,
                required: false,
                serialized_name: 'endorserType',
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
