using CBARatesServiceReference;
using Microsoft.AspNetCore.Mvc;
using RatesAPI.Core.Interfaces;
using System.Threading.Tasks;

namespace RatesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RatesByCBAController : ControllerBase
    {
        private readonly IRatesOperations _ratesOperations;
        public RatesByCBAController(IRatesOperations ratesOperations)
        {           
            _ratesOperations = ratesOperations;
        }

        [HttpGet]
        public async Task<ExchangeRates> GetRatesByCBA()
        {
            return await _ratesOperations.ExchangeRatesLatestAsync();
        }

    }
}
