using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ExWebApiAutos.Model.ExWebApiAutosDb
{
    public partial class ExWebApiAutosDbContext : DbContext
    {
        public ExWebApiAutosDbContext()
        {
        }

        public ExWebApiAutosDbContext(DbContextOptions<ExWebApiAutosDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TAuto> TAuto { get; set; }
        public virtual DbSet<TMarca> TMarca { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("data source = localhost; initial catalog = ExWebApiAutos; user id = SQLcarlos; password = admin");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TAuto>(entity =>
            {
                entity.Property(e => e.AutoId).ValueGeneratedNever();

                entity.Property(e => e.AutoAnioFab).IsUnicode(false);

                entity.Property(e => e.AutoColor).IsUnicode(false);

                entity.Property(e => e.AutoNroAsientos).IsUnicode(false);

                entity.Property(e => e.AutoPlaca).IsUnicode(false);

                entity.Property(e => e.AutoTransmision).IsUnicode(false);

                entity.Property(e => e.AutoVersion).IsUnicode(false);

                entity.HasOne(d => d.Marca)
                    .WithMany(p => p.TAuto)
                    .HasForeignKey(d => d.MarcaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_T_auto_T_marca");
            });

            modelBuilder.Entity<TMarca>(entity =>
            {
                entity.Property(e => e.MarcaId).ValueGeneratedNever();

                entity.Property(e => e.MarcaNombre).IsUnicode(false);
            });
        }
    }
}
