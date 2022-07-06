using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Nification.Areas.Identity.Data;

namespace Nification.Areas.Identity.Data;

public class IdenContext : IdentityDbContext<IdenUser>
{
    public IdenContext(DbContextOptions<IdenContext> options)
        : base(options)
    {
    }


   
    
    public DbSet<Nification.Areas.Identity.Data.IdenUser>? IdenUsers { get; set; }




}

