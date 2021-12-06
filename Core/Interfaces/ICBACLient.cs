using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RatesAPI.Core.Interfaces
{
    public interface ICBACLient
    {
        Task<CBARatesServiceReference.ExchangeRates> ExchangeRatesLatestAsync();
    }
}
