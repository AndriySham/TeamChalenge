using Microsoft.EntityFrameworkCore;
using TeamChallenge.Core.Models;

namespace TeamChallenge.Core
{
    public class AppDbContext : DbContext
    {
        public DbSet<TestData> TestDatas { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
    }
}
