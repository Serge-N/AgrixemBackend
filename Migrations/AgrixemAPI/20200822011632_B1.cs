using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace AgrixemAPI.Migrations.AgrixemAPI
{
    public partial class B1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cattle",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TagID = table.Column<long>(nullable: false),
                    FarmID = table.Column<int>(nullable: false),
                    CurrentValue = table.Column<int>(nullable: false),
                    Breed = table.Column<string>(maxLength: 20, nullable: false),
                    Color = table.Column<string>(maxLength: 15, nullable: false),
                    Name = table.Column<string>(maxLength: 15, nullable: true),
                    Sex = table.Column<string>(maxLength: 10, nullable: false),
                    Status = table.Column<string>(maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cattle", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Farms",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 20, nullable: false),
                    Length = table.Column<int>(nullable: false),
                    Width = table.Column<int>(nullable: false),
                    InitialCost = table.Column<int>(nullable: true),
                    District = table.Column<string>(maxLength: 20, nullable: false),
                    Province = table.Column<string>(maxLength: 20, nullable: false),
                    Owner = table.Column<string>(maxLength: 50, nullable: false),
                    DoP = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Farms", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Growth",
                columns: table => new
                {
                    CattleID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CattleFK = table.Column<long>(nullable: false),
                    DateOfBirth = table.Column<DateTime>(nullable: true),
                    DateOfSale = table.Column<DateTime>(nullable: true),
                    DateOfWeaning = table.Column<DateTime>(nullable: true),
                    DateOfPurchase = table.Column<DateTime>(nullable: true),
                    BirthWeight = table.Column<int>(nullable: true),
                    SalePrice = table.Column<int>(nullable: true),
                    SaleWeight = table.Column<int>(nullable: true),
                    WeaningWeight = table.Column<int>(nullable: true),
                    PurchaseValue = table.Column<int>(nullable: true),
                    Buyer = table.Column<string>(maxLength: 20, nullable: true),
                    Mode = table.Column<string>(maxLength: 10, nullable: true),
                    Seller = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Growth", x => x.CattleID);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnimalType = table.Column<string>(nullable: false),
                    FarmID = table.Column<int>(nullable: false),
                    AnimalID = table.Column<long>(nullable: false),
                    Time = table.Column<DateTime>(nullable: false),
                    Temperature = table.Column<int>(nullable: false),
                    Lat = table.Column<decimal>(nullable: false),
                    Lon = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Pasture",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FarmID = table.Column<int>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    StopDate = table.Column<DateTime>(nullable: false),
                    FeedType = table.Column<string>(maxLength: 20, nullable: false),
                    Cost = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pasture", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Pedigree",
                columns: table => new
                {
                    CattleID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CattleFK = table.Column<long>(nullable: false),
                    MotherID = table.Column<long>(nullable: true),
                    FatherID = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedigree", x => x.CattleID);
                });

            migrationBuilder.CreateTable(
                name: "Vaccination",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FarmID = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Purpose = table.Column<string>(maxLength: 20, nullable: false),
                    Detail = table.Column<string>(maxLength: 20, nullable: true),
                    DrugName = table.Column<string>(maxLength: 20, nullable: true),
                    DrugQuality = table.Column<int>(nullable: true),
                    DrugUnits = table.Column<string>(maxLength: 15, nullable: true),
                    Remark = table.Column<string>(maxLength: 50, nullable: true),
                    Done = table.Column<string>(maxLength: 7, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vaccination", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Fertility",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CattleID = table.Column<long>(nullable: false),
                    Alive = table.Column<string>(nullable: false),
                    DateOfCalving = table.Column<DateTime>(nullable: true),
                    DateofExpecting = table.Column<DateTime>(nullable: true),
                    DateOfHeating = table.Column<DateTime>(nullable: true),
                    ConceptionNumber = table.Column<int>(nullable: true),
                    NumberOfCalves = table.Column<int>(nullable: true),
                    Remarks = table.Column<string>(maxLength: 50, nullable: false)
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
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CattleID = table.Column<long>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    StopDate = table.Column<DateTime>(nullable: false),
                    FeedType = table.Column<string>(maxLength: 20, nullable: false)
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
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CattleID = table.Column<long>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Disease = table.Column<string>(maxLength: 30, nullable: false),
                    Cure = table.Column<string>(maxLength: 25, nullable: false),
                    DrugName = table.Column<string>(maxLength: 20, nullable: true),
                    DrugAmount = table.Column<int>(nullable: true),
                    DrugUnits = table.Column<string>(maxLength: 10, nullable: true),
                    Remarks = table.Column<string>(maxLength: 50, nullable: false)
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
                name: "Farms");

            migrationBuilder.DropTable(
                name: "Fertility");

            migrationBuilder.DropTable(
                name: "Food");

            migrationBuilder.DropTable(
                name: "Growth");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Pasture");

            migrationBuilder.DropTable(
                name: "Pedigree");

            migrationBuilder.DropTable(
                name: "Treatment");

            migrationBuilder.DropTable(
                name: "Vaccination");

            migrationBuilder.DropTable(
                name: "Cattle");
        }
    }
}
