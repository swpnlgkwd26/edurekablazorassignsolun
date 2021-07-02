using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blazor_app.Data
{
    public class EdurekaDBContext : DbContext
    {
        public EdurekaDBContext(DbContextOptions<EdurekaDBContext> options)
            : base(options)
        {
        }
        public DbSet<Account> Accounts { get; set; }
    }
}
