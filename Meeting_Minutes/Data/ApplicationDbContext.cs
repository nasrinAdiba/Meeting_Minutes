using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;

namespace Meeting_Minutes.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
            //public virtual DbSet<Corporate> Corporate_Customer_tbl { get; set; } = null!;
            //public virtual DbSet<Individual> Individual_Customer_tbl { get; set; } = null!;
    
    }
}