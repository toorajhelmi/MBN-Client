using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using MessageBankNet.Models;
using MessageBankNet.Views;
using Newtonsoft.Json;

namespace MessageBankNet.Services
{
    public class DataStore : IDataStore
    {
        HttpClient client = new HttpClient();

        public DataStore()
        {
            client.BaseAddress = new Uri("http://ec2-18-216-154-92.us-east-2.compute.amazonaws.com:8080/token/");
        }

        public async Task<Balance> GetBalance(string account)
        {
            var response = await client.GetAsync($"getBalance?address={account}");
            return JsonConvert.DeserializeObject<Balance>(await response.Content.ReadAsStringAsync());
        }

        public async Task Mint(string account, int tokenCount)
        {
            try
            {
                await client.PostAsync("mintToken", new StringContent(JsonConvert.SerializeObject(new Transaction
                {
                    Address = account,
                    Tokens = tokenCount
                }), Encoding.UTF8, "application/json"));
            }
            catch (Exception e)
            {

            }
        }

        public async Task SendToken(Transaction transaction)
        {
            await client.PostAsync("sendToken", new StringContent(JsonConvert.SerializeObject(transaction), Encoding.UTF8, "application/json"));
        }
    }
}
