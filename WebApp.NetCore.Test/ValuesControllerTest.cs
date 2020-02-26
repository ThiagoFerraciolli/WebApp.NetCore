using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using WebApp.NetCore.Application;
using Xunit;
using System.Threading.Tasks;
using System.Net;

namespace WebApp.NetCore.Test
{
    public class ValuesControllerTest
    {
        private readonly HttpClient _client;

        public ValuesControllerTest()
        {
            var server = new TestServer(new WebHostBuilder()
                .UseEnvironment("Development")
                .UseStartup<Startup>());
            _client = server.CreateClient();
        }

        [Theory]
        [InlineData("GET",21)]
        public async Task ValuesGetTestAsync(string metodo, int Id)
        {
            var request = new HttpRequestMessage(new HttpMethod(metodo), $"/{Id}");

            var response = await _client.SendAsync(request);

            var responseString = await response.Content.ReadAsStringAsync();
            response.EnsureSuccessStatusCode();
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);

            Assert.Equal(responseString, "{\"extenso\":\"vinte e um\"}");
        }
    }
}
