using Microsoft.EntityFrameworkCore;

namespace AracKiralamaSitesiCoreProje.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Arac> aracs { get; set; }
        public DbSet<Musteri> musteris { get; set; }
        public DbSet<Kiralama> kiralamas { get; set; }
        public DbSet<Admin> admins { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // AracDurum alanı için varsayılan değeri true yap
            modelBuilder.Entity<Arac>()
                .Property(a => a.AracDurum)
                .HasDefaultValue(true);
        }
    }
}
