using System;
using System.Threading.Tasks;
using Microsoft.Rest;
using Streetcred.Cloud.Client;
using Streetcred.Cloud.Client.Models;
using Xunit;

namespace ServiceClient.Tests
{
    public class UnitTest1
    {
        private string accessToken = "eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsImtpZCI6Ilg1ZVhrNHh5b2pORnVtMWtsMll0djhkbE5QNC1jNTdkTzZRR1RWQndhTmsifQ.eyJleHAiOjE1NDgwMzgyMDIsIm5iZiI6MTU0ODAzNDYwMiwidmVyIjoiMS4wIiwiaXNzIjoiaHR0cHM6Ly9zdHJlZXRjcmVkaWQuYjJjbG9naW4uY29tLzkyOTgxN2U5LWQ5YjgtNGFiZi1iNDJmLWNkMDQ1MDYwYWI5Ny92Mi4wLyIsInN1YiI6IjIwZTBhMzU2LTk0NTQtNDgyZC1hM2Y0LTU3ZGNlYzgyMzUxYiIsImF1ZCI6IjNhNjFiOGUzLTkyNzgtNDk1Zi04ODliLTJlMmZjYjUxZDBjMyIsIm5vbmNlIjoiYmNiOGRhZGQtMzcyZi00YmJhLWI1OTktYmZkNzE3ZGE0OWFjIiwiaWF0IjoxNTQ4MDM0NjAyLCJhdXRoX3RpbWUiOjE1NDgwMzQ2MDIsImdpdmVuX25hbWUiOiJUb21pc2xhdiIsImZhbWlseV9uYW1lIjoiTWFya292c2tpIiwibmFtZSI6IlRvbWlzbGF2IE1hcmtvdnNraSIsImlkcCI6ImZhY2Vib29rLmNvbSIsIm9pZCI6IjIwZTBhMzU2LTk0NTQtNDgyZC1hM2Y0LTU3ZGNlYzgyMzUxYiIsImVtYWlscyI6WyJ0bWFya292c2tpQGdtYWlsLmNvbSJdLCJ0ZnAiOiJCMkNfMV9zdXNpIn0.KsShJg2N_PgIvsA2yhTyWMlDvTjKoyV2qPx5U21EZZrC89HAfb4DyfTdpgqjDIfNXBdUK_X5Zm96Bhe07HEIBk3w0V95nn3Mzio5aFHyeFuAlRCBDCnSRRZeYgePEkSqsODU7jGFgvNBs9Wjay0MU65BAHDLqnik7djN9hNiSIBOiyPPocUObKtuSKcAKqV4xXQWMeZ3I8YHV3eM1s660yUun7fhWblo95o9DuYRgmlxq-jyzponxZp-SqFl3_D857IlV7MfIasoriR1Kjk_5IK0EnxVgWd0psVemwiv0vKYndQKheccM-9xXbEsMi4mHhXU0DBy_Nt7Pw22SPqpRA";

        [Fact]
        public async Task Test1()
        {
            var client = new CloudServiceClient(new TokenCredentials(accessToken))
            {
                BaseUri = new Uri("http://localhost:5009/")
            };

            var walletId = await client.CreateWalletAsync(new WalletInfo
            {
                Name = "My Wallet",
                Type = "edge"
            });
        }
    }
}
