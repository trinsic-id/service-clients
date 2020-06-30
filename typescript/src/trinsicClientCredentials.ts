import { ServiceClientCredentials, WebResource, ServiceClientOptions } from "@azure/ms-rest-js";
import { CredentialsServiceClientOptions } from "./credentials/models"
import { WalletServiceClientOptions } from "./wallet/models"
import { ProviderServiceClientOptions } from "./provider/models"

export class TrinsicCredentialsClientOptions implements CredentialsServiceClientOptions {
    noRetryPolicy?: boolean;
    baseUri?: string;
}

export class TrinsicWalletClientOptions implements WalletServiceClientOptions {
    noRetryPolicy?: boolean
    baseUri?: string;
}

export class TrinsicProviderClientOptions implements ProviderServiceClientOptions {
    noRetryPolicy?: boolean
    baseUri?: string;
}

export class TrinsicClientCredentials implements ServiceClientCredentials {
    accessToken: string
    subscriptionKey: string;

    constructor(accessToken: string, subscriptionKey: string) {
        this.accessToken = accessToken;
        this.subscriptionKey = subscriptionKey;
    }

    signRequest(webResource: WebResource): Promise<WebResource> {
        webResource.headers.set("Authorization", `Bearer ${this.accessToken}`);
        webResource.headers.set("X-Trinsic-Subscription-Key", this.subscriptionKey);
        return Promise.resolve(webResource);
    }
}

export class TrinsicProviderCredentials implements ServiceClientCredentials {
    accountSecret: string

    constructor(accountSecret: string) {
        this.accountSecret = accountSecret;
    }

    signRequest(webResource: WebResource): Promise<WebResource> {
        webResource.headers.set("Authorization", `Bearer ${this.accountSecret}`);
        return Promise.resolve(webResource);
    }
}