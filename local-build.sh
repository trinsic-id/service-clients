#!/bin/bash

npm install -g autorest;
autorest --typescript --input-file=openapi/custodian.json --add-credentials --output-folder=typescript/custodian --override-client-name=CustodianClient --custom-service-client-options=[baseUri='https://api.streetcred.id/'] 
autorest --typescript --input-file=openapi/agency.json    --add-credentials --output-folder=typescript/agency    --override-client-name=AgencyClient    --custom-service-client-options=[baseUri='https://api.streetcred.id/']
npm install typescript/custodian
npm install typescript/agency
