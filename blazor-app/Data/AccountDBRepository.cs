using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blazor_app.Data
{
    public class AccountDBRepository : IStoreRepository
    {
        private readonly EdurekaDBContext _context;

        public AccountDBRepository(EdurekaDBContext context)
        {
            _context = context;
        }
     
        public Task<List<Account>> GetAccounts()
        {
            return Task.FromResult(_context.Accounts.ToList());
        }
        public async Task AddAccount(Account account)
        {
            _context.Accounts.Add(account); 
           await _context.SaveChangesAsync(); 
        }
        public async Task DeleteAccount(int accountNumber)
        {
            var account = _context.Accounts.Single(p => p.AccountNumber == accountNumber);// Find
            _context.Accounts.Remove(account); 
            await _context.SaveChangesAsync();            
        }  
        public IEnumerable<Account> GetAccount(string accountType)
        {
            var accounts = _context.Accounts.Where(x => x.TypeOfAccount == accountType);
            return accounts;
        }
        public async Task<Account> GetAccountByNumber(int accountNumber)
        {
            return await _context.Accounts.FindAsync(accountNumber);
        }
        public async Task UpdateAccount(Account account)
        {
            _context.Accounts.Update(account);
            await _context.SaveChangesAsync();            
        }
    }
}
