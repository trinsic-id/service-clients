#!/bin/sh
# NOTE: Run from the ./ruby directory

DEFAULT_VERSION='1.1.4000'

# Generate service clients
autorest --ruby --add-credentials=true --input-file=../openapi/credentials.json --output-folder=gem/lib/ --override-client-name=CredentialsClient --package-version=${DEFAULT_VERSION}
autorest --ruby --add-credentials=true --input-file=../openapi/wallet.json --output-folder=gem/lib/ --override-client-name=WalletClient --package-version=${DEFAULT_VERSION}
autorest --ruby --add-credentials=true --input-file=../openapi/provider.json --output-folder=gem/lib/ --override-client-name=ProviderClient --package-version=${DEFAULT_VERSION}

# If on a mac
if [[ "$OSTYPE" == "darwin"* ]]; then
    # Increment version number
    sed -i "" "s/0\.0\.0/${DEFAULT_VERSION}/g" gem/trinsic_service_clients.gemspec
else
    # Increment version number
    sed -i "s/0\.0\.0/${DEFAULT_VERSION}/g" gem/trinsic_service_clients.gemspec
fi

# Build gem
cd gem && gem build trinsic_service_clients.gemspec && cd ..
