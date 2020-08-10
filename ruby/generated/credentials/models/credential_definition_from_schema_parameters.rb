# encoding: utf-8
# Code generated by Microsoft (R) AutoRest Code Generator.
# Changes may cause incorrect behavior and will be lost if the code is
# regenerated.

module Credentials
  module Models
    #
    # Represents a request object to create new credential definition for an
    # agency
    #
    class CredentialDefinitionFromSchemaParameters
      # @return [String] Schema name
      attr_accessor :name

      # @return [String] Schema version
      attr_accessor :version

      # @return [Array<String>] Schema attribute names
      attr_accessor :attributes

      # @return [Boolean] Support credential revocation
      attr_accessor :support_revocation

      # @return [String] Unique tag to differentiate definitions of the same
      # schema
      attr_accessor :tag


      #
      # Mapper for CredentialDefinitionFromSchemaParameters class as Ruby Hash.
      # This will be used for serialization/deserialization.
      #
      def self.mapper()
        {
          client_side_validation: true,
          required: false,
          serialized_name: 'CredentialDefinitionFromSchemaParameters',
          type: {
            name: 'Composite',
            class_name: 'CredentialDefinitionFromSchemaParameters',
            model_properties: {
              name: {
                client_side_validation: true,
                required: true,
                serialized_name: 'name',
                type: {
                  name: 'String'
                }
              },
              version: {
                client_side_validation: true,
                required: true,
                serialized_name: 'version',
                type: {
                  name: 'String'
                }
              },
              attributes: {
                client_side_validation: true,
                required: true,
                serialized_name: 'attributes',
                type: {
                  name: 'Sequence',
                  element: {
                      client_side_validation: true,
                      required: false,
                      serialized_name: 'StringElementType',
                      type: {
                        name: 'String'
                      }
                  }
                }
              },
              support_revocation: {
                client_side_validation: true,
                required: false,
                serialized_name: 'supportRevocation',
                type: {
                  name: 'Boolean'
                }
              },
              tag: {
                client_side_validation: true,
                required: false,
                serialized_name: 'tag',
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
