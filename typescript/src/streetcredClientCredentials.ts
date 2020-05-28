import { ServiceClientCredentials, WebResource, ServiceClientOptions } from "@azure/ms-rest-js";
import { AgencyServiceClientOptions } from "./agency/models"
import { CustodianServiceClientOptions } from "./custodian/models"
import { ManagementServiceClientOptions } from "./management/models"

export class StreetcredAgencyClientOptions implements AgencyServiceClientOptions {
    noRetryPolicy?: boolean;
    baseUri?: string;
}

export class StreetcredCustodianClientOptions implements CustodianServiceClientOptions {
    noRetryPolicy?: boolean
    baseUri?: string;
}

export class StreetcredManagementClientOptions implements ManagementServiceClientOptions {
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

export class StreetcredManagementCredentials implements ServiceClientCredentials {
    accountSecret: string

    constructor(accountSecret: string) {
        this.accountSecret = accountSecret;
    }

    signRequest(webResource: WebResource): Promise<WebResource> {
        webResource.headers.set("Authorization", `Bearer ${this.accountSecret}`);
        return Promise.resolve(webResource);
    }
}