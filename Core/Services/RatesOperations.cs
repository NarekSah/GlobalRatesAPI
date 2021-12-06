using CBARatesServiceReference;
using Microsoft.AspNetCore.Mvc;
using RatesAPI.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RatesAPI.Core.Services
{
    public class RatesOperations : IRatesOperations
    {
        private readonly IFixerIOClient _fixerIOClient;
        private readonly ICBACLient _cBACLient;

        public RatesOperations(IFixerIOClient fixerIOClient, ICBACLient cBACLient)
        {
            _fixerIOClient = fixerIOClient;
            _cBACLient = cBACLient;
        }

        public async Task<ExchangeRates> ExchangeRatesLatestAsync()
        {
            return await _cBACLient.ExchangeRatesLatestAsync();
        }

        public async Task<FixerIOResponse> GetLatestRatesAsync()
        {
            return await _fixerIOClient.GetLatestRatesAsync();
        }


    }
}
