# coding=utf-8
# --------------------------------------------------------------------------
# Code generated by Microsoft (R) AutoRest Code Generator.
# Changes may cause incorrect behavior and will be lost if the code is
# regenerated.
# --------------------------------------------------------------------------

from msrest.serialization import Model


class BasicMessageParameters(Model):
    """Basic message parameters.

    :param connection_id: The connection identifier
    :type connection_id: str
    :param text: The message text
    :type text: str
    """

    _attribute_map = {
        'connection_id': {'key': 'connectionId', 'type': 'str'},
        'text': {'key': 'text', 'type': 'str'},
    }

    def __init__(self, *, connection_id: str=None, text: str=None, **kwargs) -> None:
        super(BasicMessageParameters, self).__init__(**kwargs)
        self.connection_id = connection_id
        self.text = text