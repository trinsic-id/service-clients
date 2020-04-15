import { ServiceClientCredentials, WebResource, ServiceClientOptions } from "@azure/ms-rest-js";
import { AgencyServiceClientOptions } from "./agency/models"
import { CustodianServiceClientOptions } from "./custodian/models"

export class StreetcredAgencyClientOptions implements AgencyServiceClientOptions {
    noRetryPolicy?: boolean;
    baseUri?: string;
}

export class StreetcredCustodianClientOptions implements CustodianServiceClientOptions {
    noRetryPolicy?: boolean
    baseUri?: string;
}

export class StreetcredClientCredentials implements ServiceClientCredentials {
    accessToken: string
    subscriptionKey: string;

    constructor(accessToken: string, subscriptionKey: string) {
        this.accessToken = accessToken;
        this.subscriptionKey = subscriptionKey;
    }

    signRequest(webResource: WebResource): Promise<WebResource> {
        webResource.headers.set("Authorization", `Bearer ${this.accessToken}`);
        webResource.headers.set("X-Streetcred-Subscription-Key", this.subscriptionKey);
        return Promise.resolve(webResource);
    }
}