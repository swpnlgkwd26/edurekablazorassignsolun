using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blazor_app.Data
{
    public interface IStoreRepository
    {
        Task<List<Account>> GetAccounts();
        Task AddAccount(Account account);
        Task DeleteAccount(int accountNumber);
        Task UpdateAccount(Account account);
        IEnumerable<Account> GetAccount(string accountType);
        Task<Account> GetAccountByNumber(int accountNumber);
    }
}
