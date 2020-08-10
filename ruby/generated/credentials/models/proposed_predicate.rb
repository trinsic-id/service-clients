# encoding: utf-8
# Code generated by Microsoft (R) AutoRest Code Generator.
# Changes may cause incorrect behavior and will be lost if the code is
# regenerated.

module Credentials
  module Models
    #
    # Model object.
    #
    #
    class ProposedPredicate
      # @return [String]
      attr_accessor :name

      # @return [String]
      attr_accessor :credential_definition_id

      # @return [String]
      attr_accessor :issuer_did

      # @return [String]
      attr_accessor :schema_id

      # @return [String]
      attr_accessor :predicate

      # @return [Integer]
      attr_accessor :threshold

      # @return [String]
      attr_accessor :referent


      #
      # Mapper for ProposedPredicate class as Ruby Hash.
      # This will be used for serialization/deserialization.
      #
      def self.mapper()
        {
          client_side_validation: true,
          required: false,
          serialized_name: 'ProposedPredicate',
          type: {
            name: 'Composite',
            class_name: 'ProposedPredicate',
            model_properties: {
              name: {
                client_side_validation: true,
                required: false,
                serialized_name: 'name',
                type: {
                  name: 'String'
                }
              },
              credential_definition_id: {
                client_side_validation: true,
                required: false,
                serialized_name: 'credentialDefinitionId',
                type: {
                  name: 'String'
                }
              },
              issuer_did: {
                client_side_validation: true,
                required: false,
                serialized_name: 'issuerDid',
                type: {
                  name: 'String'
                }
              },
              schema_id: {
                client_side_validation: true,
                required: false,
                serialized_name: 'schemaId',
                type: {
                  name: 'String'
                }
              },
              predicate: {
                client_side_validation: true,
                required: false,
                serialized_name: 'predicate',
                type: {
                  name: 'String'
                }
              },
              threshold: {
                client_side_validation: true,
                required: false,
                serialized_name: 'threshold',
                type: {
                  name: 'Number'
                }
              },
              referent: {
                client_side_validation: true,
                required: false,
                serialized_name: 'referent',
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
