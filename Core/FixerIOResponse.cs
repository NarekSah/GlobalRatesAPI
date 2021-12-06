using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RatesAPI.Core
{
    public class FixerIOResponse
    {
        public bool success { get; set; }
        public int timestamp { get; set; }        
        [JsonPropertyName("base")]
        public string Base { get; set; }
        [JsonPropertyName("date")]
        public DateTime Date { get; set; }
        public Dictionary<string,float> rates { get; set; }

    }
}
