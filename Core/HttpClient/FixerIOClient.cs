using RatesAPI.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace RatesAPI.Core.HttpClient
{
    public class FixerIOClient : IFixerIOClient
    {
        private readonly IHttpClientFactory _clientFactory;
        public FixerIOClient(IHttpClientFactory ClientFactory)
        {
            _clientFactory = ClientFactory;
        }
        public async Task<FixerIOResponse> GetLatestRatesAsync()
        {
            FixerIOResponse Rates = new FixerIOResponse();
            var request = new HttpRequestMessage(HttpMethod.Post,
            "http://data.fixer.io/api/latest?access_key=b3d22af562d1d7c1e74ca146884fc221&format=1");

            var client = _clientFactory.CreateClient();

            var response = await client.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                Rates = await JsonSerializer.DeserializeAsync<FixerIOResponse>(responseStream);
            }
            return Rates;
        }
    }
}
