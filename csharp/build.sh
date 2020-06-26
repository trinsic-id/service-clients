#! /bin/bash

autorest --input-file=../openapi/custodian.json --csharp --output-folder=Generated --namespace=Streetcred.ServiceClients --add-credentials --override-client-name=CustodianServiceClient
autorest --input-file=../openapi/agency.json --csharp --output-folder=Generated --namespace=Streetcred.ServiceClients --add-credentials --override-client-name=AgencyServiceClient
autorest --input-file=../openapi/management.json --csharp --output-folder=Generated --namespace=Streetcred.ServiceClients --add-credentials --override-client-name=ManagementServiceClient

dotnet pack

