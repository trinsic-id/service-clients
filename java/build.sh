#!/bin/sh
# NOTE: Run from the ./java directory

DEFAULT_VERSION='1.0.0'

# Generate service clients
autorest --java --add-credentials --input-file=../openapi/credentials.json --output-folder=. --namespace=com.trinsic.serviceclients.credentials --override-client-name=CredentialsClient --package-version=${DEFAULT_VERSION}
autorest --java --add-credentials --input-file=../openapi/wallet.json --output-folder=. --namespace=com.trinsic.serviceclients.wallet --override-client-name=WalletClient --package-version=${DEFAULT_VERSION}
autorest --java --add-credentials --input-file=../openapi/provider.json --output-folder=. --namespace=com.trinsic.serviceclients.provider --override-client-name=ProviderClient --package-version=${DEFAULT_VERSION}

# If on a mac
if [[ "$OSTYPE" == "darwin"* ]]; then
    # Increment version number
    sed -i "" "s/{versionNumber}/${DEFAULT_VERSION}/g" pom.xml
else
    # Increment version number
    sed -i "s/{versionNumber}/${DEFAULT_VERSION}/g" pom.xml
fi

javadoc -protected -splitindex -d src/main/javadoc @javadoc_args

mvn install