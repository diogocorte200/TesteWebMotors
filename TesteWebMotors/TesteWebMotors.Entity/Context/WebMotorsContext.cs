using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TesteWebMotors.Entity.Entity;

namespace TesteWebMotors.Entity.Context
{
    public partial class WebMotorsContext : DbContext
    {

        public WebMotorsContext(DbContextOptions<WebMotorsContext> options)
            : base(options)
        {
        }
        public DbSet<AnuncioWebMotorsEntity> AnuncioWebMotorsEntities{ get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder
            .UseLazyLoadingProxies();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AnuncioWebMotorsEntity>()
             .HasKey(x => x.Id);
        }

        public override int SaveChanges()
        {
            return base.SaveChanges();
        }

        public async Task<int> SaveChangesAsync()
        {
            return await base.SaveChangesAsync();
        }
    }
}
