using System;
using Newtonsoft.Json;

namespace MessageBankNet.Models
{
    public class Balance
    {
        [JsonProperty("ether")]
        public double Ether { get; set; }
        [JsonProperty("token")]
        public int Token { get; set; }
        [JsonProperty("message")]
        public string Message { get; set; }
    }
}
