using CBARatesServiceReference;
using Microsoft.Web.Services3.Messaging;
using RatesAPI.Core.Interfaces;
using System.Threading.Tasks;

namespace RatesAPI.Core.SoapClient
{
    public class CBASoapClient : ICBACLient
    {
        public async Task<ExchangeRates> ExchangeRatesLatestAsync()
        {
            var client = new GateSoapClient(GateSoapClient.EndpointConfiguration.GateSoap);
            await client.OpenAsync();
            ExchangeRates result = await client.ExchangeRatesLatestAsync();
            client.Close();
            return result;
        }
    }    
}
