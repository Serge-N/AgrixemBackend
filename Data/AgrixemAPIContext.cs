using Microsoft.EntityFrameworkCore;
using AgrixemAPI.Core.Models.Production.Cattle;
using AgrixemAPI.Core.Models.General;
using AgrixemAPI.Core.Models;
using AgrixemAPI.Core.Models.Management;

namespace AgrixemAPI.Data
{
    public class AgrixemAPIContext : DbContext
    {
        public AgrixemAPIContext (DbContextOptions<AgrixemAPIContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            #region Farm Data Config
            builder.Entity<Farms>().HasKey(e => e.ID);
            builder.Entity<Farms>(entity =>
            {
                entity.Property(e => e.Owner).HasMaxLength(50).IsRequired();
                entity.Property(e => e.Name).HasMaxLength(20).IsRequired();
                entity.Property(e => e.Province).HasMaxLength(20).IsRequired();
                entity.Property(e => e.District).HasMaxLength(20).IsRequired();
            });
            #endregion

            #region Cattle

            builder.Entity<Cattle>(entity =>
            {
                //configure Cattle Properties
                entity.HasKey(e => e.ID);
                entity.Property(e => e.FarmID).IsRequired();
                entity.Property(e => e.Breed).IsRequired().HasMaxLength(20);
                entity.Property(e => e.Color).IsRequired().HasMaxLength(15);
                entity.Property(e => e.Sex).IsRequired().HasMaxLength(10);
                entity.Property(e => e.Status).IsRequired().HasMaxLength(10);
                entity.Property(e => e.Name).HasMaxLength(15).IsRequired(false);
            });

            builder.Entity<Pedigree>(entity =>
            {
                entity.HasKey(e => e.CattleID);
            });

            builder.Entity<Fertility>(entity =>
            {
                entity.HasKey(e => e.ID);

                //Configure a one to many relationship with Cattle
                entity.HasOne<Cattle>()
                .WithMany().HasForeignKey(p => p.CattleID);

                entity.Property(e => e.Remarks).HasMaxLength(50).IsRequired();

            });

            builder.Entity<Growth>(entity =>
            {
                entity.HasKey(e => e.CattleID);
                entity.Property(e => e.Mode).HasMaxLength(10);
                entity.Property(e => e.Buyer).HasMaxLength(20);
            });

            builder.Entity<Food>(entity =>
            {
                entity.HasKey(e => e.ID);

                //Configure a one to many relationship with Cattle
                entity.HasOne<Cattle>()
                .WithMany().HasForeignKey(p => p.CattleID);

                entity.Property(e => e.FeedType).HasMaxLength(20).IsRequired();
                entity.Property(e => e.StartDate).IsRequired();
                entity.Property(e => e.StopDate).IsRequired();

            });

            builder.Entity<Treatment>(entity =>
            {
                entity.HasKey(e => e.ID);

                //Configure a one to many relationship with Cattle
                entity.HasOne<Cattle>()
                .WithMany().HasForeignKey(p => p.CattleID);

                entity.Property(e => e.Cure).HasMaxLength(25).IsRequired();
                entity.Property(e => e.Disease).HasMaxLength(30).IsRequired();
                entity.Property(e => e.Remarks).HasMaxLength(50).IsRequired();
                entity.Property(e => e.Date).IsRequired();
                entity.Property(e => e.DrugName).HasMaxLength(20);
                entity.Property(e => e.DrugUnits).HasMaxLength(10);
            });

            builder.Entity<Vaccination>(entity =>
            {
                entity.Property(e => e.FarmID).IsRequired();
                entity.Property(e => e.Date).IsRequired();
                entity.Property(e => e.Purpose).IsRequired().HasMaxLength(20);
                entity.Property(e => e.Remark).HasMaxLength(50);
                entity.Property(e => e.DrugName).HasMaxLength(20);
                entity.Property(e => e.Done).HasMaxLength(7).IsRequired();
                entity.Property(e => e.Detail).HasMaxLength(20);
                entity.Property(e => e.DrugUnits).HasMaxLength(15);

            });

            builder.Entity<Pasture>(entity =>
            {
                entity.HasKey(e => e.ID);
                entity.Property(e => e.FarmID).IsRequired();
                entity.Property(e => e.FeedType).HasMaxLength(20).IsRequired();
                entity.Property(e => e.StartDate).IsRequired();
                entity.Property(e => e.StopDate).IsRequired();

            });

            #endregion

            #region Management 
            builder.Entity<Location>(entity =>
            {
                entity.HasKey(e => e.ID);
            });
            #endregion
        }

        #region DbSets
        public DbSet<Farms> Farms { get; set; }
        public DbSet<Cattle> Cattle { get; set; }
        public DbSet<Growth> Growth { get; set; }
        public DbSet<Treatment> Treatment { get; set; }
        public DbSet<Food> Food { get; set; }
        public DbSet<Fertility> Fertility { get; set; }
        public DbSet<Vaccination> Vaccination { get; set; }
        public DbSet<Pasture> Pasture { get; set; }
        public DbSet<Pedigree> Pedigree { get; set; }
        public DbSet<Location> Locations { get; set; }
        #endregion
    }
}
