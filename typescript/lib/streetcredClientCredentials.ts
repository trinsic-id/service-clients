import { ServiceClientCredentials, WebResource } from "@azure/ms-rest-js";

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