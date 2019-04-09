using System;
using System.Threading.Tasks;
using Microsoft.Rest;
using Streetcred.Cloud.Client;
using Streetcred.Cloud.Client.Models;
using Streetcred.Portal.Client;
using Xunit;

namespace ServiceClient.Tests
{
    public class UnitTest1
    {
        private string accessToken = "eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsImtpZCI6Ilg1ZVhrNHh5b2pORnVtMWtsMll0djhkbE5QNC1jNTdkTzZRR1RWQndhTmsifQ.eyJleHAiOjE1NTQ5MjczNTMsIm5iZiI6MTU1NDg0MDk1MywidmVyIjoiMS4wIiwiaXNzIjoiaHR0cHM6Ly9zdHJlZXRjcmVkaWQuYjJjbG9naW4uY29tLzkyOTgxN2U5LWQ5YjgtNGFiZi1iNDJmLWNkMDQ1MDYwYWI5Ny92Mi4wLyIsInN1YiI6IjljMzZkMmRiLTlhMGMtNDhhYS1hMWJlLTlhMmY0ZjM5Yzc0NiIsImF1ZCI6IjNhNjFiOGUzLTkyNzgtNDk1Zi04ODliLTJlMmZjYjUxZDBjMyIsIm5vbmNlIjoiMWU0YzczNjYtMGJkNy00ZmQ0LWExNDctOTdjZjI1ZWYyOWI1IiwiaWF0IjoxNTU0ODQwOTUzLCJhdXRoX3RpbWUiOjE1NTQ4NDA5NTMsIm9pZCI6IjljMzZkMmRiLTlhMGMtNDhhYS1hMWJlLTlhMmY0ZjM5Yzc0NiIsImZhbWlseV9uYW1lIjoiTWFya292c2tpIiwiZ2l2ZW5fbmFtZSI6IlRvbWlzbGF2IiwibmFtZSI6InVua25vd24iLCJlbWFpbHMiOlsidG1hcmtvdnNraUBnbWFpbC5jb20iXSwidGZwIjoiQjJDXzFfc3VzaSJ9.a-EChSWck88CQ3Au_qEZNYd87AvS4cWwYL9u8IUJqb4lniKVhrmfkW1MKxoQe9GqvBvtsI5ysLmqQOqLDVNo_pAZw01nedS5vcF5FkgJewXLpN0jS_gCU5aURTgue97n4pIomYlVQ7Kz2HSpqy3Y008o15H2jD6GvRPrRb_MfV8ZVBqmnfFlp8qPl0dZBZaE3TJvCuDcBKZBWk-zZ7nL4_sEfPQnMoeC1GGr2iMSvrmG6Epux-GDMKJOB8seGnGP6H0JWTXCLYFvsq5BQdlt14dJ-4NrEGjp4Vwz-FcktTy-XJlQNYVfVo0nrpOmq7tgp7GhSkHTQ-TDwFDWE1K2zQ";

        [Fact]
        public async Task Test1()
        {
            var client = new PortalServiceClient(new TokenCredentials(accessToken))
            {
                BaseUri = new Uri("http://localhost:5000/")
            };

            var walletId = await client.ListProofRequestsAsync("fXX2pUFOvnSlEzwRyde8K83d");
        }
    }
}
