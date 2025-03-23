using Microsoft.EntityFrameworkCore;
using System.Configuration;


namespace SourceData.Data
{
    public partial class SourceDBContext : DbContext
    {
        public SourceDBContext()
        {
        }

        public SourceDBContext(DbContextOptions<SourceDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Contact> Contacts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
				var settings = ConfigurationManager.ConnectionStrings["SourceDB"];
				optionsBuilder.UseSqlServer(settings.ConnectionString);
			}
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
                entity.Property(e => e.FirstName);
                entity.Property(e => e.LastName);
                entity.Property(e => e.Email);
                entity.Property(e => e.IsSent);
			});
        }
    }
}
