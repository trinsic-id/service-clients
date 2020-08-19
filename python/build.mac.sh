#!/bin/sh
# RUN FROM THE service_clients/python DIRECTORY

# Generate Service Clients
autorest --python --add-credentials=true --input-file=../openapi/credentials.json --output-folder=package/trinsic/service_clients --override-client-name=CredentialsClient --package-name=trinsic.service_clients.credentials
autorest --python --add-credentials=true --input-file=../openapi/wallet.json --output-folder=package/trinsic/service_clients --override-client-name=WalletClient --package-name=trinsic.service_clients.wallet
autorest --python --add-credentials=true --input-file=../openapi/provider.json --output-folder=package/trinsic/service_clients --override-client-name=ProviderClient --package-name=trinsic.service_clients.provider

# Rename credentials_property
sed -i "" "s/credentials_property/credentials/g" package/trinsic/service_clients/credentials/credentials_client.py
# Update version_number
sed -i "" "s/version_number/1.1.4000/g" package/setup.py

# Build package
cd package && python setup.py sdist bdist_wheel && cd ..