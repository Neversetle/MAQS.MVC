using MAQS.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace MAQS.Web.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<CompanyContact> CompanyContact { get; set; }
    }
}
