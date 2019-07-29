export class ServiceClientOptions {
    constructor(accessToken: string, subscriptionKey: string) {
        this.accessToken = accessToken;
        this.subscriptionKey = subscriptionKey;
    }
    accessToken: string
    subscriptionKey: string;
}