# coding=utf-8
# --------------------------------------------------------------------------
# Code generated by Microsoft (R) AutoRest Code Generator.
# Changes may cause incorrect behavior and will be lost if the code is
# regenerated.
# --------------------------------------------------------------------------

from msrest.serialization import Model


class VerificationResult(Model):
    """Verification result.

    :param valid: True if verification passed, otherwise False
    :type valid: bool
    :param proof: Verification Proof Details
    :type proof: dict[str, ~credentials.models.ProofAttributeContract]
    """

    _attribute_map = {
        'valid': {'key': 'valid', 'type': 'bool'},
        'proof': {'key': 'proof', 'type': '{ProofAttributeContract}'},
    }

    def __init__(self, **kwargs):
        super(VerificationResult, self).__init__(**kwargs)
        self.valid = kwargs.get('valid', None)
        self.proof = kwargs.get('proof', None)