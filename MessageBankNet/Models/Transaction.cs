using System;
using Newtonsoft.Json;

namespace MessageBankNet.Models
{
    public class Transaction
    {
        [JsonProperty("address")]
        public string Address { get; set; }
        [JsonProperty("mMessage")]
        public string Message { get; set; }
        [JsonProperty("tokens")]
        public int Tokens { get; set; }
    }
}