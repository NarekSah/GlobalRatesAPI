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

        public RatesOperations(IFixerIOClient fixerIOClient)
        {
            _fixerIOClient = fixerIOClient;
        }
        public async Task<FixerIOResponse> GetLatestRatesAsync()
        {
            return await _fixerIOClient.GetLatestRatesAsync();
        }
    }
}
