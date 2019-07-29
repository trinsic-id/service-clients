import { ServiceClientCredentials, WebResource } from "@azure/ms-rest-js";
import { ServiceClientOptions } from "./serviceClientOptions"

export class StreetcredClientCredentials implements ServiceClientCredentials {
    options: ServiceClientOptions;

    constructor (options: ServiceClientOptions) {
        this.options = options;
    }
    signRequest(webResource: WebResource): Promise<WebResource> {
        webResource.headers.set("Authorization", `Bearer ${this.options.accessToken}`);
        webResource.headers.set("X-Streetcred-Subscription-Key", this.options.subscriptionKey);
        return Promise.resolve(webResource);
    }
}