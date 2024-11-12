using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using apiData.Database.Tables;

namespace apiData.Database
{
    public class apiDbContext : DbContext
    {
        public apiDbContext(DbContextOptions<apiDbContext> opts) : base(opts)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<artista>()
                .HasOne<pais>()
                .WithMany()
                .HasForeignKey(a => a.id_pais)
                .IsRequired();

            modelBuilder.Entity<artista>()
                .HasOne<banda>()
                .WithMany()
                .HasForeignKey(a => a.id_banda)
                .IsRequired();

            modelBuilder.Entity<album>()
                .HasOne<banda>()
                .WithMany()
                .HasForeignKey(a => a.id_banda)
                .IsRequired();

            modelBuilder.Entity<cancion>()
                .HasOne<album>()
                .WithMany()
                .HasForeignKey(c => c.id_album)
                .IsRequired();

            modelBuilder.Entity<banda>()
                .HasOne<generoMusical>()
                .WithMany()
                .HasForeignKey(b => b.id_genero)
                .IsRequired();
             
                
         }

        public DbSet<banda> bandas { get; set; }
        public DbSet<album> albums { get; set; }
        public DbSet<artista> artists { get; set; }
        public DbSet<pais> pais { get; set; }
        public DbSet<generoMusical> generoMusicals { get; set; }
        public DbSet<cancion> cancion { get; set; }
    }
}
