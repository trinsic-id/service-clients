#! /bin/bash

autorest --input-file=../openapi/wallet.json --csharp --output-folder=Generated --namespace=Trinsic.ServiceClients --add-credentials --override-client-name=WalletServiceClient
autorest --input-file=../openapi/credentials.json --csharp --output-folder=Generated --namespace=Trinsic.ServiceClients --add-credentials --override-client-name=CredentialsServiceClient
autorest --input-file=../openapi/provider.json --csharp --output-folder=Generated --namespace=Trinsic.ServiceClients --add-credentials --override-client-name=ProviderServiceClient

dotnet pack

