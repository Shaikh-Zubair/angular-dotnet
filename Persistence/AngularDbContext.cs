using angular_dotnet.Model;
using Microsoft.EntityFrameworkCore;

namespace angular_dotnet.Persistence
{
    public class AngularDbContext : DbContext
    {
        public AngularDbContext(DbContextOptions<AngularDbContext> options)
            : base(options)
        { }

        public DbSet<Makes> Makes { get; set; }
        public DbSet<Models> Models { get; set; }
        public DbSet<Features> Features { get; set; }

        // protected override void OnModelCreating(ModelBuilder modelBuilder)
        // {
        //     // modelBuilder.Entity<Makes>(entity =>
        //     // {
        //     //     entity.ToTable("Makes");

        //     //     entity.Property(e => e.Id).HasColumnType("int(11)");

        //     //     entity.Property(e => e.Name)
        //     //         .IsRequired()
        //     //         .HasColumnType("varchar(255)")
        //     //         .HasCharSet("utf8mb4")
        //     //         .HasCollation("utf8mb4_0900_ai_ci");
        //     // });

        //     // modelBuilder.Entity<Models>(entity =>
        //     // {
        //     //     entity.ToTable("Models");

        //     //     entity.HasIndex(e => e.MakeId)
        //     //         .HasName("IX_Models_MakeId");

        //     //     entity.Property(e => e.Id).HasColumnType("int(11)");

        //     //     entity.Property(e => e.MakeId).HasColumnType("int(11)");

        //     //     entity.Property(e => e.Name)
        //     //         .IsRequired()
        //     //         .HasColumnType("varchar(255)")
        //     //         .HasCharSet("utf8mb4")
        //     //         .HasCollation("utf8mb4_0900_ai_ci");

        //     //     entity.HasOne(d => d.Make)
        //     //         .WithMany(p => p.Models)
        //     //         .HasForeignKey(d => d.MakeId)
        //     //         .HasConstraintName("FK_Models_Makes_MakeId");
        //     // });

        //     modelBuilder.Entity<Features>(entity =>
        //     {
        //         entity.ToTable("Features");

        //         entity.Property(e => e.Id).HasColumnType("int(11)");

        //         entity.Property(e => e.Name)
        //             .IsRequired()
        //             .HasColumnType("varchar(255)")
        //             .HasCharSet("utf8mb4")
        //             .HasCollation("utf8mb4_0900_ai_ci");
        //     });

        //     OnModelCreatingPartial(modelBuilder);
        // }

        // void OnModelCreatingPartial(ModelBuilder modelBuilder)
        // { }
    }
}