using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace RatesAPI.Core.Interfaces
{
    public interface IFixerIOClient
    {
        Task<FixerIOResponse> GetLatestRatesAsync();          
    }
}
