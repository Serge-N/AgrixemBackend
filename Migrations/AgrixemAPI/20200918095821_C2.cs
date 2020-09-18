using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AgrixemAPI.Migrations.AgrixemAPI
{
    public partial class C2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cure",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GoatID = table.Column<long>(nullable: false),
                    StartingDate = table.Column<DateTime>(nullable: false),
                    StoppingDate = table.Column<DateTime>(nullable: false),
                    Type = table.Column<string>(maxLength: 30, nullable: true),
                    Reason = table.Column<string>(maxLength: 50, nullable: true),
                    Effect = table.Column<string>(maxLength: 60, nullable: true),
                    DrugName = table.Column<string>(maxLength: 40, nullable: true),
                    Quantity = table.Column<int>(nullable: true),
                    Units = table.Column<string>(maxLength: 15, nullable: true),
                    Recovered = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cure", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(maxLength: 30, nullable: false),
                    Phone = table.Column<string>(maxLength: 15, nullable: false),
                    Email = table.Column<string>(maxLength: 25, nullable: true),
                    Address = table.Column<string>(maxLength: 300, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Goat",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FarmID = table.Column<int>(nullable: false),
                    EarTagNumber = table.Column<int>(nullable: true),
                    LeftEarTatoo = table.Column<int>(nullable: true),
                    RightEarTatoo = table.Column<int>(nullable: true),
                    RegisteredNumber = table.Column<long>(nullable: false),
                    RegisteredName = table.Column<string>(maxLength: 15, nullable: true),
                    Breed = table.Column<string>(maxLength: 20, nullable: false),
                    Sex = table.Column<string>(maxLength: 10, nullable: false),
                    Status = table.Column<string>(maxLength: 10, nullable: false),
                    Colour = table.Column<string>(maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Goat", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "GoatFeed",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GoatID = table.Column<long>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    StopDate = table.Column<DateTime>(nullable: true),
                    Feed = table.Column<string>(maxLength: 30, nullable: true),
                    StartingWeight = table.Column<int>(nullable: true),
                    StopingWeight = table.Column<int>(nullable: true),
                    Cost = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoatFeed", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "GroupCure",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(nullable: false),
                    FarmID = table.Column<long>(nullable: false),
                    Type = table.Column<string>(maxLength: 30, nullable: true),
                    Reason = table.Column<string>(maxLength: 30, nullable: true),
                    Effect = table.Column<string>(maxLength: 30, nullable: true),
                    DrugAmount = table.Column<int>(nullable: true),
                    DrugUnits = table.Column<string>(maxLength: 10, nullable: true),
                    Cost = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupCure", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Kid",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GoatID = table.Column<long>(nullable: false),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    BirthWeight = table.Column<int>(nullable: false),
                    ThirtyDayWeight = table.Column<int>(nullable: true),
                    SixityDayWeight = table.Column<int>(nullable: true),
                    NinetyDayWeight = table.Column<int>(nullable: true),
                    WeaningDate = table.Column<DateTime>(nullable: true),
                    WeaningWeight = table.Column<int>(nullable: true),
                    Abnomalies = table.Column<string>(maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kid", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Market",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FarmID = table.Column<int>(nullable: false),
                    GoatID = table.Column<long>(nullable: false),
                    CustomerID = table.Column<long>(nullable: false),
                    SalePrice = table.Column<int>(nullable: false),
                    SaleWeight = table.Column<int>(nullable: false),
                    Mode = table.Column<string>(maxLength: 20, nullable: false),
                    Comments = table.Column<string>(maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Market", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Source",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GoatID = table.Column<long>(nullable: false),
                    DoeID = table.Column<long>(nullable: true),
                    BuckID = table.Column<long>(nullable: true),
                    PurchasePrice = table.Column<int>(nullable: true),
                    SupplierID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Source", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Supplier",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(maxLength: 30, nullable: false),
                    Phone = table.Column<string>(maxLength: 15, nullable: false),
                    Email = table.Column<string>(maxLength: 25, nullable: true),
                    Address = table.Column<string>(maxLength: 300, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supplier", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cure");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Goat");

            migrationBuilder.DropTable(
                name: "GoatFeed");

            migrationBuilder.DropTable(
                name: "GroupCure");

            migrationBuilder.DropTable(
                name: "Kid");

            migrationBuilder.DropTable(
                name: "Market");

            migrationBuilder.DropTable(
                name: "Source");

            migrationBuilder.DropTable(
                name: "Supplier");
        }
    }
}
