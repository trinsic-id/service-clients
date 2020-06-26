#! /bin/bash

autorest --input-file=http://streetcred-cw-api-staging.azurewebsites.net/swagger/v1/swagger.json --csharp --output-folder=Generated --namespace=Streetcred.ServiceClients --add-credentials --override-client-name=CustodianServiceClient
autorest --input-file=http://streetcred-agency-api-staging.azurewebsites.net/swagger/v1/swagger.json --csharp --output-folder=Generated --namespace=Streetcred.ServiceClients --add-credentials --override-client-name=AgencyServiceClient
autorest --input-file=../openapi/management.json --csharp --output-folder=Generated --namespace=Streetcred.ServiceClients --add-credentials --override-client-name=ManagementServiceClient

dotnet pack

