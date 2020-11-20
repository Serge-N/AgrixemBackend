using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AgrixemAPI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cattle",
                columns: table => new
                {
                    ID = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TagID = table.Column<long>(type: "INTEGER", nullable: false),
                    FarmID = table.Column<int>(type: "INTEGER", nullable: false),
                    CurrentValue = table.Column<int>(type: "INTEGER", nullable: false),
                    Breed = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    Color = table.Column<string>(type: "TEXT", maxLength: 15, nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 15, nullable: true),
                    Sex = table.Column<string>(type: "TEXT", maxLength: 10, nullable: false),
                    Status = table.Column<string>(type: "TEXT", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cattle", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Cure",
                columns: table => new
                {
                    ID = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    GoatID = table.Column<long>(type: "INTEGER", nullable: false),
                    StartingDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    StoppingDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Type = table.Column<string>(type: "TEXT", maxLength: 30, nullable: true),
                    Reason = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    Effect = table.Column<string>(type: "TEXT", maxLength: 60, nullable: true),
                    DrugName = table.Column<string>(type: "TEXT", maxLength: 40, nullable: true),
                    Quantity = table.Column<int>(type: "INTEGER", nullable: true),
                    Units = table.Column<string>(type: "TEXT", maxLength: 15, nullable: true),
                    Recovered = table.Column<char>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cure", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    ID = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FullName = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    Phone = table.Column<string>(type: "TEXT", maxLength: 15, nullable: false),
                    Email = table.Column<string>(type: "TEXT", maxLength: 25, nullable: true),
                    Address = table.Column<string>(type: "TEXT", maxLength: 300, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Doe",
                columns: table => new
                {
                    ID = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    GoatID = table.Column<long>(type: "INTEGER", nullable: false),
                    DateOfMating = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DateOfExpectionLate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DateOfExpectionActual = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Kids = table.Column<int>(type: "INTEGER", nullable: false),
                    Remarks = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doe", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Farms",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    Length = table.Column<int>(type: "INTEGER", nullable: false),
                    Width = table.Column<int>(type: "INTEGER", nullable: false),
                    InitialCost = table.Column<int>(type: "INTEGER", nullable: true),
                    District = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    Province = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    Owner = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    DoP = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Farms", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Goat",
                columns: table => new
                {
                    ID = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FarmID = table.Column<int>(type: "INTEGER", nullable: false),
                    EarTagNumber = table.Column<int>(type: "INTEGER", nullable: true),
                    LeftEarTatoo = table.Column<int>(type: "INTEGER", nullable: true),
                    RightEarTatoo = table.Column<int>(type: "INTEGER", nullable: true),
                    RegisteredNumber = table.Column<long>(type: "INTEGER", nullable: false),
                    RegisteredName = table.Column<string>(type: "TEXT", maxLength: 15, nullable: true),
                    Breed = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    Sex = table.Column<string>(type: "TEXT", maxLength: 10, nullable: false),
                    Status = table.Column<string>(type: "TEXT", maxLength: 10, nullable: false),
                    Colour = table.Column<string>(type: "TEXT", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Goat", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "GoatFeed",
                columns: table => new
                {
                    ID = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    GoatID = table.Column<long>(type: "INTEGER", nullable: false),
                    StartDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    StopDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Feed = table.Column<string>(type: "TEXT", maxLength: 30, nullable: true),
                    StartingWeight = table.Column<int>(type: "INTEGER", nullable: true),
                    StopingWeight = table.Column<int>(type: "INTEGER", nullable: true),
                    Cost = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoatFeed", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "GroupCure",
                columns: table => new
                {
                    ID = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    FarmID = table.Column<long>(type: "INTEGER", nullable: false),
                    Type = table.Column<string>(type: "TEXT", maxLength: 30, nullable: true),
                    Reason = table.Column<string>(type: "TEXT", maxLength: 30, nullable: true),
                    Effect = table.Column<string>(type: "TEXT", maxLength: 30, nullable: true),
                    DrugAmount = table.Column<int>(type: "INTEGER", nullable: true),
                    DrugUnits = table.Column<string>(type: "TEXT", maxLength: 10, nullable: true),
                    Cost = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupCure", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Growth",
                columns: table => new
                {
                    CattleID = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CattleFK = table.Column<long>(type: "INTEGER", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "TEXT", nullable: true),
                    DateOfSale = table.Column<DateTime>(type: "TEXT", nullable: true),
                    DateOfWeaning = table.Column<DateTime>(type: "TEXT", nullable: true),
                    DateOfPurchase = table.Column<DateTime>(type: "TEXT", nullable: true),
                    BirthWeight = table.Column<int>(type: "INTEGER", nullable: true),
                    SalePrice = table.Column<int>(type: "INTEGER", nullable: true),
                    SaleWeight = table.Column<int>(type: "INTEGER", nullable: true),
                    WeaningWeight = table.Column<int>(type: "INTEGER", nullable: true),
                    PurchaseValue = table.Column<int>(type: "INTEGER", nullable: true),
                    Buyer = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true),
                    Mode = table.Column<string>(type: "TEXT", maxLength: 10, nullable: true),
                    Seller = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Growth", x => x.CattleID);
                });

            migrationBuilder.CreateTable(
                name: "Kid",
                columns: table => new
                {
                    ID = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    GoatID = table.Column<long>(type: "INTEGER", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    BirthWeight = table.Column<int>(type: "INTEGER", nullable: false),
                    ThirtyDayWeight = table.Column<int>(type: "INTEGER", nullable: true),
                    SixityDayWeight = table.Column<int>(type: "INTEGER", nullable: true),
                    NinetyDayWeight = table.Column<int>(type: "INTEGER", nullable: true),
                    WeaningDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    WeaningWeight = table.Column<int>(type: "INTEGER", nullable: true),
                    Abnomalies = table.Column<string>(type: "TEXT", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kid", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    ID = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FarmID = table.Column<int>(type: "INTEGER", nullable: false),
                    AnimalID = table.Column<long>(type: "INTEGER", nullable: false),
                    AnimalType = table.Column<char>(type: "TEXT", nullable: false),
                    Timestamp = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Speed = table.Column<double>(type: "REAL", nullable: true),
                    VerticalAccuracy = table.Column<double>(type: "REAL", nullable: true),
                    Accuracy = table.Column<double>(type: "REAL", nullable: true),
                    Altitude = table.Column<double>(type: "REAL", nullable: true),
                    Course = table.Column<double>(type: "REAL", nullable: true),
                    Lat = table.Column<double>(type: "REAL", nullable: false),
                    Lon = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Market",
                columns: table => new
                {
                    ID = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FarmID = table.Column<int>(type: "INTEGER", nullable: false),
                    GoatID = table.Column<long>(type: "INTEGER", nullable: false),
                    CustomerID = table.Column<long>(type: "INTEGER", nullable: false),
                    SalePrice = table.Column<int>(type: "INTEGER", nullable: false),
                    SaleWeight = table.Column<int>(type: "INTEGER", nullable: false),
                    Mode = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    Comments = table.Column<string>(type: "TEXT", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Market", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Pasture",
                columns: table => new
                {
                    ID = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FarmID = table.Column<int>(type: "INTEGER", nullable: false),
                    StartDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    StopDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    FeedType = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    Cost = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pasture", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Pedigree",
                columns: table => new
                {
                    CattleID = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CattleFK = table.Column<long>(type: "INTEGER", nullable: false),
                    MotherID = table.Column<long>(type: "INTEGER", nullable: true),
                    FatherID = table.Column<long>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedigree", x => x.CattleID);
                });

            migrationBuilder.CreateTable(
                name: "Source",
                columns: table => new
                {
                    ID = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    GoatID = table.Column<long>(type: "INTEGER", nullable: false),
                    DoeID = table.Column<long>(type: "INTEGER", nullable: true),
                    BuckID = table.Column<long>(type: "INTEGER", nullable: true),
                    PurchasePrice = table.Column<int>(type: "INTEGER", nullable: true),
                    SupplierID = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Source", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Supplier",
                columns: table => new
                {
                    ID = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FullName = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    Phone = table.Column<string>(type: "TEXT", maxLength: 15, nullable: false),
                    Email = table.Column<string>(type: "TEXT", maxLength: 25, nullable: true),
                    Address = table.Column<string>(type: "TEXT", maxLength: 300, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supplier", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Vaccination",
                columns: table => new
                {
                    ID = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FarmID = table.Column<int>(type: "INTEGER", nullable: false),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Purpose = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    Detail = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true),
                    DrugName = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true),
                    DrugQuality = table.Column<int>(type: "INTEGER", nullable: true),
                    DrugUnits = table.Column<string>(type: "TEXT", maxLength: 15, nullable: true),
                    Remark = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    Done = table.Column<string>(type: "TEXT", maxLength: 7, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vaccination", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Fertility",
                columns: table => new
                {
                    ID = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CattleID = table.Column<long>(type: "INTEGER", nullable: false),
                    Alive = table.Column<char>(type: "TEXT", nullable: false),
                    DateOfCalving = table.Column<DateTime>(type: "TEXT", nullable: true),
                    DateofExpecting = table.Column<DateTime>(type: "TEXT", nullable: true),
                    DateOfHeating = table.Column<DateTime>(type: "TEXT", nullable: true),
                    ConceptionNumber = table.Column<int>(type: "INTEGER", nullable: true),
                    NumberOfCalves = table.Column<int>(type: "INTEGER", nullable: true),
                    Remarks = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fertility", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Fertility_Cattle_CattleID",
                        column: x => x.CattleID,
                        principalTable: "Cattle",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Food",
                columns: table => new
                {
                    ID = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CattleID = table.Column<long>(type: "INTEGER", nullable: false),
                    StartDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    StopDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    FeedType = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Food", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Food_Cattle_CattleID",
                        column: x => x.CattleID,
                        principalTable: "Cattle",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Treatment",
                columns: table => new
                {
                    ID = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CattleID = table.Column<long>(type: "INTEGER", nullable: false),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Disease = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    Cure = table.Column<string>(type: "TEXT", maxLength: 25, nullable: false),
                    DrugName = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true),
                    DrugAmount = table.Column<int>(type: "INTEGER", nullable: true),
                    DrugUnits = table.Column<string>(type: "TEXT", maxLength: 10, nullable: true),
                    Remarks = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Treatment", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Treatment_Cattle_CattleID",
                        column: x => x.CattleID,
                        principalTable: "Cattle",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Fertility_CattleID",
                table: "Fertility",
                column: "CattleID");

            migrationBuilder.CreateIndex(
                name: "IX_Food_CattleID",
                table: "Food",
                column: "CattleID");

            migrationBuilder.CreateIndex(
                name: "IX_Treatment_CattleID",
                table: "Treatment",
                column: "CattleID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cure");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Doe");

            migrationBuilder.DropTable(
                name: "Farms");

            migrationBuilder.DropTable(
                name: "Fertility");

            migrationBuilder.DropTable(
                name: "Food");

            migrationBuilder.DropTable(
                name: "Goat");

            migrationBuilder.DropTable(
                name: "GoatFeed");

            migrationBuilder.DropTable(
                name: "GroupCure");

            migrationBuilder.DropTable(
                name: "Growth");

            migrationBuilder.DropTable(
                name: "Kid");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Market");

            migrationBuilder.DropTable(
                name: "Pasture");

            migrationBuilder.DropTable(
                name: "Pedigree");

            migrationBuilder.DropTable(
                name: "Source");

            migrationBuilder.DropTable(
                name: "Supplier");

            migrationBuilder.DropTable(
                name: "Treatment");

            migrationBuilder.DropTable(
                name: "Vaccination");

            migrationBuilder.DropTable(
                name: "Cattle");
        }
    }
}
