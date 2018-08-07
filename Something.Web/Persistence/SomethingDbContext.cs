using Microsoft.EntityFrameworkCore;
using Something.Web.Models;

namespace Something.Web.Persistence
{
    public class SomethingDbContext : DbContext
    {
        public SomethingDbContext(DbContextOptions<SomethingDbContext> options)
            : base(options)
        {
        }

        public DbSet<CategoryModel> CategoryModel { get; set; }

        public DbSet<PostModel> PostModel { get; set; }
    }
}
