#!/bin/sh
# NOTE: Run from the ./ruby directory

DEFAULT_VERSION='1.1.4000'

# Clear the generated directories
rm -rf gem/lib/generated gem/lib/trinsic_service_clients

# Generate service clients
autorest --ruby --add-credentials=true --input-file=../openapi/credentials.json --output-folder=gem/lib/ --override-client-name=CredentialsClient --package-version=${DEFAULT_VERSION}
autorest --ruby --add-credentials=true --input-file=../openapi/wallet.json --output-folder=gem/lib/ --override-client-name=WalletClient --package-version=${DEFAULT_VERSION}
autorest --ruby --add-credentials=true --input-file=../openapi/provider.json --output-folder=gem/lib/ --override-client-name=ProviderClient --package-version=${DEFAULT_VERSION}

# Move files to correct structure
mv gem/lib/generated gem/lib/trinsic_service_clients

# Build gem
cd gem && gem build trinsic_service_clients.gemspec cd ..

