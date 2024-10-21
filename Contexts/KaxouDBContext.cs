using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Testing.Models.CustomerFiles;
using Testing.Models.DbSettings;
using Testing.Models.OrderFiles;

namespace Testing.Contexts
{
    public partial class KaxouDBContext : DbContext
    {

        private readonly DbSettings _dbsettings;
        public KaxouDBContext(DbContextOptions<KaxouDBContext> options, IOptions<DbSettings> dbSettings) : base(options)
        {
            _dbsettings = dbSettings.Value;
        }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CustomerConfiguration());
            modelBuilder.ApplyConfiguration(new OrderConfiguration());
            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
