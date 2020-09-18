using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace AgrixemAPI.Migrations.AgrixemAPI
{
    public partial class B2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Temperature",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "Time",
                table: "Locations");

            migrationBuilder.AlterColumn<double>(
                name: "Lon",
                table: "Locations",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<double>(
                name: "Lat",
                table: "Locations",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddColumn<double>(
                name: "Accuracy",
                table: "Locations",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Altitude",
                table: "Locations",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Course",
                table: "Locations",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Speed",
                table: "Locations",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Timestamp",
                table: "Locations",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<double>(
                name: "VerticalAccuracy",
                table: "Locations",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Accuracy",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "Altitude",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "Course",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "Speed",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "Timestamp",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "VerticalAccuracy",
                table: "Locations");

            migrationBuilder.AlterColumn<decimal>(
                name: "Lon",
                table: "Locations",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<decimal>(
                name: "Lat",
                table: "Locations",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AddColumn<int>(
                name: "Temperature",
                table: "Locations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "Time",
                table: "Locations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
