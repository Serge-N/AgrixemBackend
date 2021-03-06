﻿// <auto-generated />
using System;
using AgrixemAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AgrixemAPI.Migrations
{
    [DbContext(typeof(AgrixemAPIContext))]
    partial class AgrixemAPIContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("AgrixemAPI.Core.Models.General.Farms", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("District")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DoP")
                        .HasColumnType("TEXT");

                    b.Property<int?>("InitialCost")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Length")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<string>("Owner")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Province")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<int>("Width")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.ToTable("Farms");
                });

            modelBuilder.Entity("AgrixemAPI.Core.Models.Management.Location", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double?>("Accuracy")
                        .HasColumnType("REAL");

                    b.Property<double?>("Altitude")
                        .HasColumnType("REAL");

                    b.Property<long>("AnimalID")
                        .HasColumnType("INTEGER");

                    b.Property<char>("AnimalType")
                        .HasColumnType("TEXT");

                    b.Property<double?>("Course")
                        .HasColumnType("REAL");

                    b.Property<int>("FarmID")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Lat")
                        .HasColumnType("REAL");

                    b.Property<double>("Lon")
                        .HasColumnType("REAL");

                    b.Property<double?>("Speed")
                        .HasColumnType("REAL");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("TEXT");

                    b.Property<double?>("VerticalAccuracy")
                        .HasColumnType("REAL");

                    b.HasKey("ID");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("AgrixemAPI.Core.Models.Pedigree", b =>
                {
                    b.Property<long>("CattleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("CattleFK")
                        .HasColumnType("INTEGER");

                    b.Property<long?>("FatherID")
                        .HasColumnType("INTEGER");

                    b.Property<long?>("MotherID")
                        .HasColumnType("INTEGER");

                    b.HasKey("CattleID");

                    b.ToTable("Pedigree");
                });

            modelBuilder.Entity("AgrixemAPI.Core.Models.Production.Cattle.Cattle", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Breed")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("TEXT");

                    b.Property<int>("CurrentValue")
                        .HasColumnType("INTEGER");

                    b.Property<int>("FarmID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasMaxLength(15)
                        .HasColumnType("TEXT");

                    b.Property<string>("Sex")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.Property<long>("TagID")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.ToTable("Cattle");
                });

            modelBuilder.Entity("AgrixemAPI.Core.Models.Production.Cattle.Fertility", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<char>("Alive")
                        .HasColumnType("TEXT");

                    b.Property<long>("CattleID")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ConceptionNumber")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("DateOfCalving")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DateOfHeating")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DateofExpecting")
                        .HasColumnType("TEXT");

                    b.Property<int?>("NumberOfCalves")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Remarks")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.HasIndex("CattleID");

                    b.ToTable("Fertility");
                });

            modelBuilder.Entity("AgrixemAPI.Core.Models.Production.Cattle.Food", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("CattleID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FeedType")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("StopDate")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.HasIndex("CattleID");

                    b.ToTable("Food");
                });

            modelBuilder.Entity("AgrixemAPI.Core.Models.Production.Cattle.Growth", b =>
                {
                    b.Property<long>("CattleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("BirthWeight")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Buyer")
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<long>("CattleFK")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DateOfPurchase")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DateOfSale")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DateOfWeaning")
                        .HasColumnType("TEXT");

                    b.Property<string>("Mode")
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.Property<int?>("PurchaseValue")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("SalePrice")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("SaleWeight")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Seller")
                        .HasColumnType("TEXT");

                    b.Property<int?>("WeaningWeight")
                        .HasColumnType("INTEGER");

                    b.HasKey("CattleID");

                    b.ToTable("Growth");
                });

            modelBuilder.Entity("AgrixemAPI.Core.Models.Production.Cattle.Pasture", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Cost")
                        .HasColumnType("INTEGER");

                    b.Property<int>("FarmID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FeedType")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("StopDate")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Pasture");
                });

            modelBuilder.Entity("AgrixemAPI.Core.Models.Production.Cattle.Treatment", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("CattleID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Cure")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<string>("Disease")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<int?>("DrugAmount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("DrugName")
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<string>("DrugUnits")
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.Property<string>("Remarks")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.HasIndex("CattleID");

                    b.ToTable("Treatment");
                });

            modelBuilder.Entity("AgrixemAPI.Core.Models.Production.Cattle.Vaccination", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<string>("Detail")
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<string>("Done")
                        .IsRequired()
                        .HasMaxLength(7)
                        .HasColumnType("TEXT");

                    b.Property<string>("DrugName")
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<int?>("DrugQuality")
                        .HasColumnType("INTEGER");

                    b.Property<string>("DrugUnits")
                        .HasMaxLength(15)
                        .HasColumnType("TEXT");

                    b.Property<int>("FarmID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Purpose")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<string>("Remark")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Vaccination");
                });

            modelBuilder.Entity("AgrixemAPI.Core.Models.Production.Goats.Cure", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("DrugName")
                        .HasMaxLength(40)
                        .HasColumnType("TEXT");

                    b.Property<string>("Effect")
                        .HasMaxLength(60)
                        .HasColumnType("TEXT");

                    b.Property<long>("GoatID")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Quantity")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Reason")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<char>("Recovered")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("StartingDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("StoppingDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Type")
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<string>("Units")
                        .HasMaxLength(15)
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Cure");
                });

            modelBuilder.Entity("AgrixemAPI.Core.Models.Production.Goats.Customer", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .HasMaxLength(300)
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(25)
                        .HasColumnType("TEXT");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("AgrixemAPI.Core.Models.Production.Goats.Doe", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("DateOfExpectionActual")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateOfExpectionLate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateOfMating")
                        .HasColumnType("TEXT");

                    b.Property<long>("GoatID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Kids")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Remarks")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Doe");
                });

            modelBuilder.Entity("AgrixemAPI.Core.Models.Production.Goats.Goat", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Breed")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<string>("Colour")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("TEXT");

                    b.Property<int?>("EarTagNumber")
                        .HasColumnType("INTEGER");

                    b.Property<int>("FarmID")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("LeftEarTatoo")
                        .HasColumnType("INTEGER");

                    b.Property<string>("RegisteredName")
                        .HasMaxLength(15)
                        .HasColumnType("TEXT");

                    b.Property<long>("RegisteredNumber")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("RightEarTatoo")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Sex")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Goat");
                });

            modelBuilder.Entity("AgrixemAPI.Core.Models.Production.Goats.GoatFeed", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Cost")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Feed")
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<long>("GoatID")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("TEXT");

                    b.Property<int?>("StartingWeight")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("StopDate")
                        .HasColumnType("TEXT");

                    b.Property<int?>("StopingWeight")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.ToTable("GoatFeed");
                });

            modelBuilder.Entity("AgrixemAPI.Core.Models.Production.Goats.GroupCure", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Cost")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<int?>("DrugAmount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("DrugUnits")
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.Property<string>("Effect")
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<long>("FarmID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Reason")
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<string>("Type")
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("GroupCure");
                });

            modelBuilder.Entity("AgrixemAPI.Core.Models.Production.Goats.Kid", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Abnomalies")
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("BirthWeight")
                        .HasColumnType("INTEGER");

                    b.Property<long>("GoatID")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("NinetyDayWeight")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("SixityDayWeight")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ThirtyDayWeight")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("WeaningDate")
                        .HasColumnType("TEXT");

                    b.Property<int?>("WeaningWeight")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.ToTable("Kid");
                });

            modelBuilder.Entity("AgrixemAPI.Core.Models.Production.Goats.Market", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Comments")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("TEXT");

                    b.Property<long>("CustomerID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("FarmID")
                        .HasColumnType("INTEGER");

                    b.Property<long>("GoatID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Mode")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<int>("SalePrice")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SaleWeight")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.ToTable("Market");
                });

            modelBuilder.Entity("AgrixemAPI.Core.Models.Production.Goats.Source", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long?>("BuckID")
                        .HasColumnType("INTEGER");

                    b.Property<long?>("DoeID")
                        .HasColumnType("INTEGER");

                    b.Property<long>("GoatID")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("PurchasePrice")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("SupplierID")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.ToTable("Source");
                });

            modelBuilder.Entity("AgrixemAPI.Core.Models.Production.Goats.Supplier", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .HasMaxLength(300)
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(25)
                        .HasColumnType("TEXT");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("TEXT");

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
