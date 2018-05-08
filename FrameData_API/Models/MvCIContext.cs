using Microsoft.EntityFrameworkCore;

namespace FrameData_API.Models
{
    public partial class MvCIContext : DbContext
    {
        public virtual DbSet<MvCIFrameData> FrameData { get; set; }

        public MvCIContext(DbContextOptions<MvCIContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MvCIFrameData>(entity =>
            {
                entity.HasKey(e => e.MoveId);

                entity.ToTable("FrameData", "MvCI");

                entity.Property(e => e.MoveId).HasColumnName("MoveID");

                entity.Property(e => e.Active)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.BlockAdvantage)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CharacterName)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CounterhitAdvantage)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Damage)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.HitAdvantage)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Input)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.MoveName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Recovery)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Startup)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Total)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                //entity.Property(e => e.PunisherMove1)
                //    .HasMaxLength(40)
                //    .IsUnicode(false);

                //entity.Property(e => e.Punishable1)
                //    .HasMaxLength(40)
                //    .IsUnicode(false);
            });
        }
    }
}
