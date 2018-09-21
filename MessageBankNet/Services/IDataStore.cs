using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MessageBankNet.Models;

namespace MessageBankNet.Services
{
    public interface IDataStore
    {
        Task<Balance> GetBalance(string account);
        Task Mint(string account, int tokenCount);
        Task SendToken (Transaction transaction);
    }
}
