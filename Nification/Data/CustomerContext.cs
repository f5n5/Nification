using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Nification.Models;

namespace Nification.Data
{
    public class CustomerContext : DbContext
    {
        public CustomerContext (DbContextOptions<CustomerContext> options)
            : base(options)
        {
        }

        public DbSet<Nification.Models.Customer>? Customer { get; set; }
        public DbSet<Nification.Areas.Identity.Data.IdenUser>? IdenUsers { get; set; }
    }
}
