﻿// <auto-generated />
using System;
using AgrixemAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AgrixemAPI.Migrations.AgrixemAPI
{
    [DbContext(typeof(AgrixemAPIContext))]
    partial class AgrixemAPIContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AgrixemAPI.Core.Models.General.Farms", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("District")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<DateTime>("DoP")
                        .HasColumnType("datetime2");

                    b.Property<int?>("InitialCost")
                        .HasColumnType("int");

                    b.Property<int>("Length")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("Owner")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Province")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<int>("Width")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Farms");
                });

            modelBuilder.Entity("AgrixemAPI.Core.Models.Management.Location", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double?>("Accuracy")
                        .HasColumnType("float");

                    b.Property<double?>("Altitude")
                        .HasColumnType("float");

                    b.Property<long>("AnimalID")
                        .HasColumnType("bigint");

                    b.Property<string>("AnimalType")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<double?>("Course")
                        .HasColumnType("float");

                    b.Property<int>("FarmID")
                        .HasColumnType("int");

                    b.Property<double>("Lat")
                        .HasColumnType("float");

                    b.Property<double>("Lon")
                        .HasColumnType("float");

                    b.Property<double?>("Speed")
                        .HasColumnType("float");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("datetime2");

                    b.Property<double?>("VerticalAccuracy")
                        .HasColumnType("float");

                    b.HasKey("ID");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("AgrixemAPI.Core.Models.Pedigree", b =>
                {
                    b.Property<long>("CattleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("CattleFK")
                        .HasColumnType("bigint");

                    b.Property<long?>("FatherID")
                        .HasColumnType("bigint");

                    b.Property<long?>("MotherID")
                        .HasColumnType("bigint");

                    b.HasKey("CattleID");

                    b.ToTable("Pedigree");
                });

            modelBuilder.Entity("AgrixemAPI.Core.Models.Production.Cattle.Cattle", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Breed")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.Property<int>("CurrentValue")
                        .HasColumnType("int");

                    b.Property<int>("FarmID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.Property<string>("Sex")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<long>("TagID")
                        .HasColumnType("bigint");

                    b.HasKey("ID");

                    b.ToTable("Cattle");
                });

            modelBuilder.Entity("AgrixemAPI.Core.Models.Production.Cattle.Fertility", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Alive")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<long>("CattleID")
                        .HasColumnType("bigint");

                    b.Property<int?>("ConceptionNumber")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DateOfCalving")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateOfHeating")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateofExpecting")
                        .HasColumnType("datetime2");

                    b.Property<int?>("NumberOfCalves")
                        .HasColumnType("int");

                    b.Property<string>("Remarks")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("ID");

                    b.HasIndex("CattleID");

                    b.ToTable("Fertility");
                });

            modelBuilder.Entity("AgrixemAPI.Core.Models.Production.Cattle.Food", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("CattleID")
                        .HasColumnType("bigint");

                    b.Property<string>("FeedType")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StopDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("CattleID");

                    b.ToTable("Food");
                });

            modelBuilder.Entity("AgrixemAPI.Core.Models.Production.Cattle.Growth", b =>
                {
                    b.Property<long>("CattleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BirthWeight")
                        .HasColumnType("int");

                    b.Property<string>("Buyer")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<long>("CattleFK")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateOfPurchase")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateOfSale")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateOfWeaning")
                        .HasColumnType("datetime2");

                    b.Property<string>("Mode")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<int?>("PurchaseValue")
                        .HasColumnType("int");

                    b.Property<int?>("SalePrice")
                        .HasColumnType("int");

                    b.Property<int?>("SaleWeight")
                        .HasColumnType("int");

                    b.Property<string>("Seller")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("WeaningWeight")
                        .HasColumnType("int");

                    b.HasKey("CattleID");

                    b.ToTable("Growth");
                });

            modelBuilder.Entity("AgrixemAPI.Core.Models.Production.Cattle.Pasture", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Cost")
                        .HasColumnType("int");

                    b.Property<int>("FarmID")
                        .HasColumnType("int");

                    b.Property<string>("FeedType")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StopDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Pasture");
                });

            modelBuilder.Entity("AgrixemAPI.Core.Models.Production.Cattle.Treatment", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("CattleID")
                        .HasColumnType("bigint");

                    b.Property<string>("Cure")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)")
                        .HasMaxLength(25);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Disease")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<int?>("DrugAmount")
                        .HasColumnType("int");

                    b.Property<string>("DrugName")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("DrugUnits")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("Remarks")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("ID");

                    b.HasIndex("CattleID");

                    b.ToTable("Treatment");
                });

            modelBuilder.Entity("AgrixemAPI.Core.Models.Production.Cattle.Vaccination", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Detail")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("Done")
                        .IsRequired()
                        .HasColumnType("nvarchar(7)")
                        .HasMaxLength(7);

                    b.Property<string>("DrugName")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<int?>("DrugQuality")
                        .HasColumnType("int");

                    b.Property<string>("DrugUnits")
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.Property<int>("FarmID")
                        .HasColumnType("int");

                    b.Property<string>("Purpose")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("Remark")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("ID");

                    b.ToTable("Vaccination");
                });

            modelBuilder.Entity("AgrixemAPI.Core.Models.Production.Goats.Cure", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DrugName")
                        .HasColumnType("nvarchar(40)")
                        .HasMaxLength(40);

                    b.Property<string>("Effect")
                        .HasColumnType("nvarchar(60)")
                        .HasMaxLength(60);

                    b.Property<long>("GoatID")
                        .HasColumnType("bigint");

                    b.Property<int?>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("Reason")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Recovered")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<DateTime>("StartingDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StoppingDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("Units")
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.HasKey("ID");

                    b.ToTable("Cure");
                });

            modelBuilder.Entity("AgrixemAPI.Core.Models.Production.Goats.Customer", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(300)")
                        .HasMaxLength(300);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(25)")
                        .HasMaxLength(25);

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.HasKey("ID");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("AgrixemAPI.Core.Models.Production.Goats.Goat", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Breed")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("Colour")
                        .IsRequired()
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.Property<int?>("EarTagNumber")
                        .HasColumnType("int");

                    b.Property<int>("FarmID")
                        .HasColumnType("int");

                    b.Property<int?>("LeftEarTatoo")
                        .HasColumnType("int");

                    b.Property<string>("RegisteredName")
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.Property<long>("RegisteredNumber")
                        .HasColumnType("bigint");

                    b.Property<int?>("RightEarTatoo")
                        .HasColumnType("int");

                    b.Property<string>("Sex")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.HasKey("ID");

                    b.ToTable("Goat");
                });

            modelBuilder.Entity("AgrixemAPI.Core.Models.Production.Goats.GoatFeed", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Cost")
                        .HasColumnType("int");

                    b.Property<string>("Feed")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<long>("GoatID")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("StartingWeight")
                        .HasColumnType("int");

                    b.Property<DateTime?>("StopDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("StopingWeight")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("GoatFeed");
                });

            modelBuilder.Entity("AgrixemAPI.Core.Models.Production.Goats.GroupCure", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Cost")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DrugAmount")
                        .HasColumnType("int");

                    b.Property<string>("DrugUnits")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("Effect")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<long>("FarmID")
                        .HasColumnType("bigint");

                    b.Property<string>("Reason")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.HasKey("ID");

                    b.ToTable("GroupCure");
                });

            modelBuilder.Entity("AgrixemAPI.Core.Models.Production.Goats.Kid", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Abnomalies")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("BirthWeight")
                        .HasColumnType("int");

                    b.Property<long>("GoatID")
                        .HasColumnType("bigint");

                    b.Property<int?>("NinetyDayWeight")
                        .HasColumnType("int");

                    b.Property<int?>("SixityDayWeight")
                        .HasColumnType("int");

                    b.Property<int?>("ThirtyDayWeight")
                        .HasColumnType("int");

                    b.Property<DateTime?>("WeaningDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("WeaningWeight")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Kid");
                });

            modelBuilder.Entity("AgrixemAPI.Core.Models.Production.Goats.Market", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comments")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<long>("CustomerID")
                        .HasColumnType("bigint");

                    b.Property<int>("FarmID")
                        .HasColumnType("int");

                    b.Property<long>("GoatID")
                        .HasColumnType("bigint");

                    b.Property<string>("Mode")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<int>("SalePrice")
                        .HasColumnType("int");

                    b.Property<int>("SaleWeight")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Market");
                });

            modelBuilder.Entity("AgrixemAPI.Core.Models.Production.Goats.Source", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("BuckID")
                        .HasColumnType("bigint");

                    b.Property<long?>("DoeID")
                        .HasColumnType("bigint");

                    b.Property<long>("GoatID")
                        .HasColumnType("bigint");

                    b.Property<int?>("PurchasePrice")
                        .HasColumnType("int");

                    b.Property<int?>("SupplierID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Source");
                });

            modelBuilder.Entity("AgrixemAPI.Core.Models.Production.Goats.Supplier", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(300)")
                        .HasMaxLength(300);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(25)")
                        .HasMaxLength(25);

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.HasKey("ID");

                    b.ToTable("Supplier");
                });

            modelBuilder.Entity("AgrixemAPI.Core.Models.Production.Cattle.Fertility", b =>
                {
                    b.HasOne("AgrixemAPI.Core.Models.Production.Cattle.Cattle", null)
                        .WithMany()
                        .HasForeignKey("CattleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AgrixemAPI.Core.Models.Production.Cattle.Food", b =>
                {
                    b.HasOne("AgrixemAPI.Core.Models.Production.Cattle.Cattle", null)
                        .WithMany()
                        .HasForeignKey("CattleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AgrixemAPI.Core.Models.Production.Cattle.Treatment", b =>
                {
                    b.HasOne("AgrixemAPI.Core.Models.Production.Cattle.Cattle", null)
                        .WithMany()
                        .HasForeignKey("CattleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
