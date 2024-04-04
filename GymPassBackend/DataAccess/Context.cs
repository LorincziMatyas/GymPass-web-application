using GymPassBackend.DALs;
using Microsoft.EntityFrameworkCore;

namespace GymPassBackend.DataAccess
{
    public class Context: DbContext
    {
        public Context() {}
        public Context(DbContextOptions<Context> options) : base(options) { }

        public DbSet<Benefit> Benefits { get; set; }
        public DbSet<ImageModels> ImageModels { get; set; }
        public DbSet<Pass> Passes { get; set; }
        public DbSet<PassBenefit> PassBenefits { get; set; }
        public DbSet<ShopItem> ShopItems { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserPass> UserPasses { get; set; }
        public DbSet<UserShopItem> UserShopItems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            const string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=mysecretpassword;Database=postgres;";
            optionsBuilder.UseNpgsql(connectionString);
        }
    }
}
