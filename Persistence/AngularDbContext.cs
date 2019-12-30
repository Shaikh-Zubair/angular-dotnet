using angular_dotnet.Model;
using Microsoft.EntityFrameworkCore;

namespace angular_dotnet.Persistence
{
    public class AngularDbContext : DbContext
    {
        public AngularDbContext(DbContextOptions<AngularDbContext> options)
            : base(options)
        {}
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("server=localhost;port=3306;database=vega;user=zubair;pwd=eng!Neer!Ng998;", x => x.ServerVersion("8.0.18-mysql"));
            }
        }
        public virtual DbSet<Makes> Makes { get; set; }
        public virtual DbSet<Models> Models { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Makes>(entity =>
            {
                entity.ToTable("makes");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<Models>(entity =>
            {
                entity.ToTable("models");

                entity.HasIndex(e => e.MakeId)
                    .HasName("IX_Models_MakeId");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.MakeId).HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.HasOne(d => d.Make)
                    .WithMany(p => p.Models)
                    .HasForeignKey(d => d.MakeId)
                    .HasConstraintName("FK_Models_Makes_MakeId");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        void OnModelCreatingPartial(ModelBuilder modelBuilder)
        { }
    }
}