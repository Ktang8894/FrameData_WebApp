using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FrameData_API.Models
{
    public partial class MvCIContext : DbContext
    {
        public virtual DbSet<AllCharacters> AllCharacters { get; set; }
        public virtual DbSet<Arthur> Arthur { get; set; }
        public virtual DbSet<BlackPanther> BlackPanther { get; set; }
        public virtual DbSet<CaptainAmerica> CaptainAmerica { get; set; }
        public virtual DbSet<CaptainMarvel> CaptainMarvel { get; set; }
        public virtual DbSet<Chris> Chris { get; set; }
        public virtual DbSet<ChunLi> ChunLi { get; set; }
        public virtual DbSet<Dante> Dante { get; set; }
        public virtual DbSet<DoctorStrange> DoctorStrange { get; set; }
        public virtual DbSet<Dormammu> Dormammu { get; set; }
        public virtual DbSet<Firebrand> Firebrand { get; set; }
        public virtual DbSet<FrankWest> FrankWest { get; set; }
        public virtual DbSet<Gamora> Gamora { get; set; }
        public virtual DbSet<GhostRider> GhostRider { get; set; }
        public virtual DbSet<Haggar> Haggar { get; set; }
        public virtual DbSet<Hawkeye> Hawkeye { get; set; }
        public virtual DbSet<Hulk> Hulk { get; set; }
        public virtual DbSet<IronMan> IronMan { get; set; }
        public virtual DbSet<Jedah> Jedah { get; set; }
        public virtual DbSet<MonsterHunter> MonsterHunter { get; set; }
        public virtual DbSet<Morrigan> Morrigan { get; set; }
        public virtual DbSet<Nemesis> Nemesis { get; set; }
        public virtual DbSet<Nova> Nova { get; set; }
        public virtual DbSet<RocketRaccoon> RocketRaccoon { get; set; }
        public virtual DbSet<Ryu> Ryu { get; set; }
        public virtual DbSet<Sigma> Sigma { get; set; }
        public virtual DbSet<Spencer> Spencer { get; set; }
        public virtual DbSet<Spiderman> Spiderman { get; set; }
        public virtual DbSet<StriderHiryu> StriderHiryu { get; set; }
        public virtual DbSet<Thanos> Thanos { get; set; }
        public virtual DbSet<Thor> Thor { get; set; }
        public virtual DbSet<Ultron> Ultron { get; set; }
        public virtual DbSet<X> X { get; set; }
        public virtual DbSet<Zero> Zero { get; set; }

        public MvCIContext(DbContextOptions<MvCIContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AllCharacters>(entity =>
            {
                entity.HasKey(e => e.MoveId);

                entity.ToTable("AllCharacters", "MvCI");

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
            });

            modelBuilder.Entity<Arthur>(entity =>
            {
                entity.HasKey(e => e.MoveId);

                entity.ToTable("Arthur", "MvCI");

                entity.Property(e => e.MoveId).HasColumnName("MoveID");

                entity.Property(e => e.Active)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.BlockAdvantage)
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
            });

            modelBuilder.Entity<BlackPanther>(entity =>
            {
                entity.HasKey(e => e.MoveId);

                entity.ToTable("BlackPanther", "MvCI");

                entity.Property(e => e.MoveId).HasColumnName("MoveID");

                entity.Property(e => e.Active)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.BlockAdvantage)
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
            });

            modelBuilder.Entity<CaptainAmerica>(entity =>
            {
                entity.HasKey(e => e.MoveId);

                entity.ToTable("CaptainAmerica", "MvCI");

                entity.Property(e => e.MoveId).HasColumnName("MoveID");

                entity.Property(e => e.Active)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.BlockAdvantage)
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
            });

            modelBuilder.Entity<CaptainMarvel>(entity =>
            {
                entity.HasKey(e => e.MoveId);

                entity.ToTable("CaptainMarvel", "MvCI");

                entity.Property(e => e.MoveId).HasColumnName("MoveID");

                entity.Property(e => e.Active)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.BlockAdvantage)
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
            });

            modelBuilder.Entity<Chris>(entity =>
            {
                entity.HasKey(e => e.MoveId);

                entity.ToTable("Chris", "MvCI");

                entity.Property(e => e.MoveId).HasColumnName("MoveID");

                entity.Property(e => e.Active)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.BlockAdvantage)
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
            });

            modelBuilder.Entity<ChunLi>(entity =>
            {
                entity.HasKey(e => e.MoveId);

                entity.ToTable("ChunLi", "MvCI");

                entity.Property(e => e.MoveId).HasColumnName("MoveID");

                entity.Property(e => e.Active)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.BlockAdvantage)
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
            });

            modelBuilder.Entity<Dante>(entity =>
            {
                entity.HasKey(e => e.MoveId);

                entity.ToTable("Dante", "MvCI");

                entity.Property(e => e.MoveId).HasColumnName("MoveID");

                entity.Property(e => e.Active)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.BlockAdvantage)
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
            });

            modelBuilder.Entity<DoctorStrange>(entity =>
            {
                entity.HasKey(e => e.MoveId);

                entity.ToTable("DoctorStrange", "MvCI");

                entity.Property(e => e.MoveId).HasColumnName("MoveID");

                entity.Property(e => e.Active)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.BlockAdvantage)
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
            });

            modelBuilder.Entity<Dormammu>(entity =>
            {
                entity.HasKey(e => e.MoveId);

                entity.ToTable("Dormammu", "MvCI");

                entity.Property(e => e.MoveId).HasColumnName("MoveID");

                entity.Property(e => e.Active)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.BlockAdvantage)
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
            });

            modelBuilder.Entity<Firebrand>(entity =>
            {
                entity.HasKey(e => e.MoveId);

                entity.ToTable("Firebrand", "MvCI");

                entity.Property(e => e.MoveId).HasColumnName("MoveID");

                entity.Property(e => e.Active)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.BlockAdvantage)
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
            });

            modelBuilder.Entity<FrankWest>(entity =>
            {
                entity.HasKey(e => e.MoveId);

                entity.ToTable("FrankWest", "MvCI");

                entity.Property(e => e.MoveId).HasColumnName("MoveID");

                entity.Property(e => e.Active)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.BlockAdvantage)
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
            });

            modelBuilder.Entity<Gamora>(entity =>
            {
                entity.HasKey(e => e.MoveId);

                entity.ToTable("Gamora", "MvCI");

                entity.Property(e => e.MoveId).HasColumnName("MoveID");

                entity.Property(e => e.Active)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.BlockAdvantage)
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
            });

            modelBuilder.Entity<GhostRider>(entity =>
            {
                entity.HasKey(e => e.MoveId);

                entity.ToTable("GhostRider", "MvCI");

                entity.Property(e => e.MoveId).HasColumnName("MoveID");

                entity.Property(e => e.Active)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.BlockAdvantage)
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
            });

            modelBuilder.Entity<Haggar>(entity =>
            {
                entity.HasKey(e => e.MoveId);

                entity.ToTable("Haggar", "MvCI");

                entity.Property(e => e.MoveId).HasColumnName("MoveID");

                entity.Property(e => e.Active)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.BlockAdvantage)
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
            });

            modelBuilder.Entity<Hawkeye>(entity =>
            {
                entity.HasKey(e => e.MoveId);

                entity.ToTable("Hawkeye", "MvCI");

                entity.Property(e => e.MoveId).HasColumnName("MoveID");

                entity.Property(e => e.Active)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.BlockAdvantage)
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
            });

            modelBuilder.Entity<Hulk>(entity =>
            {
                entity.HasKey(e => e.MoveId);

                entity.ToTable("Hulk", "MvCI");

                entity.Property(e => e.MoveId).HasColumnName("MoveID");

                entity.Property(e => e.Active)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.BlockAdvantage)
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
            });

            modelBuilder.Entity<IronMan>(entity =>
            {
                entity.HasKey(e => e.MoveId);

                entity.ToTable("IronMan", "MvCI");

                entity.Property(e => e.MoveId).HasColumnName("MoveID");

                entity.Property(e => e.Active)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.BlockAdvantage)
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
            });

            modelBuilder.Entity<Jedah>(entity =>
            {
                entity.HasKey(e => e.MoveId);

                entity.ToTable("Jedah", "MvCI");

                entity.Property(e => e.MoveId).HasColumnName("MoveID");

                entity.Property(e => e.Active)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.BlockAdvantage)
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
            });

            modelBuilder.Entity<MonsterHunter>(entity =>
            {
                entity.HasKey(e => e.MoveId);

                entity.ToTable("MonsterHunter", "MvCI");

                entity.Property(e => e.MoveId).HasColumnName("MoveID");

                entity.Property(e => e.Active)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.BlockAdvantage)
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
            });

            modelBuilder.Entity<Morrigan>(entity =>
            {
                entity.HasKey(e => e.MoveId);

                entity.ToTable("Morrigan", "MvCI");

                entity.Property(e => e.MoveId).HasColumnName("MoveID");

                entity.Property(e => e.Active)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.BlockAdvantage)
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
            });

            modelBuilder.Entity<Nemesis>(entity =>
            {
                entity.HasKey(e => e.MoveId);

                entity.ToTable("Nemesis", "MvCI");

                entity.Property(e => e.MoveId).HasColumnName("MoveID");

                entity.Property(e => e.Active)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.BlockAdvantage)
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
            });

            modelBuilder.Entity<Nova>(entity =>
            {
                entity.HasKey(e => e.MoveId);

                entity.ToTable("Nova", "MvCI");

                entity.Property(e => e.MoveId).HasColumnName("MoveID");

                entity.Property(e => e.Active)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.BlockAdvantage)
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
            });

            modelBuilder.Entity<RocketRaccoon>(entity =>
            {
                entity.HasKey(e => e.MoveId);

                entity.ToTable("RocketRaccoon", "MvCI");

                entity.Property(e => e.MoveId).HasColumnName("MoveID");

                entity.Property(e => e.Active)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.BlockAdvantage)
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
            });

            modelBuilder.Entity<Ryu>(entity =>
            {
                entity.HasKey(e => e.MoveId);

                entity.ToTable("Ryu", "MvCI");

                entity.Property(e => e.MoveId).HasColumnName("MoveID");

                entity.Property(e => e.Active)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.BlockAdvantage)
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
            });

            modelBuilder.Entity<Sigma>(entity =>
            {
                entity.HasKey(e => e.MoveId);

                entity.ToTable("Sigma", "MvCI");

                entity.Property(e => e.MoveId).HasColumnName("MoveID");

                entity.Property(e => e.Active)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.BlockAdvantage)
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
            });

            modelBuilder.Entity<Spencer>(entity =>
            {
                entity.HasKey(e => e.MoveId);

                entity.ToTable("Spencer", "MvCI");

                entity.Property(e => e.MoveId).HasColumnName("MoveID");

                entity.Property(e => e.Active)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.BlockAdvantage)
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
            });

            modelBuilder.Entity<Spiderman>(entity =>
            {
                entity.HasKey(e => e.MoveId);

                entity.ToTable("Spiderman", "MvCI");

                entity.Property(e => e.MoveId).HasColumnName("MoveID");

                entity.Property(e => e.Active)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.BlockAdvantage)
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
            });

            modelBuilder.Entity<StriderHiryu>(entity =>
            {
                entity.HasKey(e => e.MoveId);

                entity.ToTable("StriderHiryu", "MvCI");

                entity.Property(e => e.MoveId).HasColumnName("MoveID");

                entity.Property(e => e.Active)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.BlockAdvantage)
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
            });

            modelBuilder.Entity<Thanos>(entity =>
            {
                entity.HasKey(e => e.MoveId);

                entity.ToTable("Thanos", "MvCI");

                entity.Property(e => e.MoveId).HasColumnName("MoveID");

                entity.Property(e => e.Active)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.BlockAdvantage)
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
            });

            modelBuilder.Entity<Thor>(entity =>
            {
                entity.HasKey(e => e.MoveId);

                entity.ToTable("Thor", "MvCI");

                entity.Property(e => e.MoveId).HasColumnName("MoveID");

                entity.Property(e => e.Active)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.BlockAdvantage)
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
            });

            modelBuilder.Entity<Ultron>(entity =>
            {
                entity.HasKey(e => e.MoveId);

                entity.ToTable("Ultron", "MvCI");

                entity.Property(e => e.MoveId).HasColumnName("MoveID");

                entity.Property(e => e.Active)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.BlockAdvantage)
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
            });

            modelBuilder.Entity<X>(entity =>
            {
                entity.HasKey(e => e.MoveId);

                entity.ToTable("X", "MvCI");

                entity.Property(e => e.MoveId).HasColumnName("MoveID");

                entity.Property(e => e.Active)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.BlockAdvantage)
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
            });

            modelBuilder.Entity<Zero>(entity =>
            {
                entity.HasKey(e => e.MoveId);

                entity.ToTable("Zero", "MvCI");

                entity.Property(e => e.MoveId).HasColumnName("MoveID");

                entity.Property(e => e.Active)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.BlockAdvantage)
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
            });
        }
    }
}
