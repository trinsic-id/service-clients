# encoding: utf-8
# Code generated by Microsoft (R) AutoRest Code Generator.
# Changes may cause incorrect behavior and will be lost if the code is
# regenerated.

module Wallet
  module Models
    #
    # Model object.
    #
    #
    class VerificationPolicyRevocationReqirement
      # @return [DateTime]
      attr_accessor :valid_at


      #
      # Mapper for VerificationPolicyRevocationReqirement class as Ruby Hash.
      # This will be used for serialization/deserialization.
      #
      def self.mapper()
        {
          client_side_validation: true,
          required: false,
          serialized_name: 'VerificationPolicyRevocationReqirement',
          type: {
            name: 'Composite',
            class_name: 'VerificationPolicyRevocationReqirement',
            model_properties: {
              valid_at: {
                client_side_validation: true,
                required: false,
                serialized_name: 'validAt',
                type: {
                  name: 'DateTime'
                }
              }
            }
          }
        }
      end
    end
  end
end
