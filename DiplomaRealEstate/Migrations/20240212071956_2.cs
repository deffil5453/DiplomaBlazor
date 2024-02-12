using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DiplomaRealEstate.Migrations
{
    /// <inheritdoc />
    public partial class _2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b05b207a-3e5d-4c8a-a035-a93da3b65c84"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e53423c1-02c3-4881-8c03-66612ad3b9f8"));

            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: new Guid("548870e1-f9d3-4b96-9636-329fcca12019"));

            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: new Guid("88fdaed1-f8f3-4abc-b8b7-7ed786011734"));

            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: new Guid("8f90301c-c16e-4c5a-96d2-c0a6895b0f76"));

            migrationBuilder.DeleteData(
                table: "TypeRealEstates",
                keyColumn: "Id",
                keyValue: new Guid("4ef79f25-8473-4d92-9ed1-7a6b2918bc24"));

            migrationBuilder.DeleteData(
                table: "TypeRealEstates",
                keyColumn: "Id",
                keyValue: new Guid("67fc4d03-bf42-48b8-85e6-6211b66c0318"));

            migrationBuilder.DropColumn(
                name: "Coordinates",
                table: "RealEstates");

            migrationBuilder.AddColumn<double>(
                name: "Latitude",
                table: "RealEstates",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Longitude",
                table: "RealEstates",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("713ac4c0-0df1-4ea8-963c-17253fa46138"), "Земельные участок" },
                    { new Guid("f8533906-8589-4862-b67f-22fe154420c3"), "Жилая собственность" }
                });

            migrationBuilder.InsertData(
                table: "Statuses",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("14487274-66a5-49a4-8793-5c42269ba727"), "Арендована" },
                    { new Guid("3d251c80-8d66-4c95-a4a8-e27dff437e49"), "Продано" },
                    { new Guid("6004af37-c8f3-4c04-9fad-962d4e603ab5"), "Активная" }
                });

            migrationBuilder.InsertData(
                table: "TypeRealEstates",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("17e6426b-8367-4928-a95a-4d2e94f319f1"), "Дом " },
                    { new Guid("596dfd07-3bde-48ce-9f9f-2666b822b797"), "Земельный участок" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("713ac4c0-0df1-4ea8-963c-17253fa46138"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f8533906-8589-4862-b67f-22fe154420c3"));

            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: new Guid("14487274-66a5-49a4-8793-5c42269ba727"));

            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: new Guid("3d251c80-8d66-4c95-a4a8-e27dff437e49"));

            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: new Guid("6004af37-c8f3-4c04-9fad-962d4e603ab5"));

            migrationBuilder.DeleteData(
                table: "TypeRealEstates",
                keyColumn: "Id",
                keyValue: new Guid("17e6426b-8367-4928-a95a-4d2e94f319f1"));

            migrationBuilder.DeleteData(
                table: "TypeRealEstates",
                keyColumn: "Id",
                keyValue: new Guid("596dfd07-3bde-48ce-9f9f-2666b822b797"));

            migrationBuilder.DropColumn(
                name: "Latitude",
                table: "RealEstates");

            migrationBuilder.DropColumn(
                name: "Longitude",
                table: "RealEstates");

            migrationBuilder.AddColumn<string>(
                name: "Coordinates",
                table: "RealEstates",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("b05b207a-3e5d-4c8a-a035-a93da3b65c84"), "Земельные участок" },
                    { new Guid("e53423c1-02c3-4881-8c03-66612ad3b9f8"), "Жилая собственность" }
                });

            migrationBuilder.InsertData(
                table: "Statuses",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("548870e1-f9d3-4b96-9636-329fcca12019"), "Продано" },
                    { new Guid("88fdaed1-f8f3-4abc-b8b7-7ed786011734"), "Арендована" },
                    { new Guid("8f90301c-c16e-4c5a-96d2-c0a6895b0f76"), "Активная" }
                });

            migrationBuilder.InsertData(
                table: "TypeRealEstates",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("4ef79f25-8473-4d92-9ed1-7a6b2918bc24"), "Дом " },
                    { new Guid("67fc4d03-bf42-48b8-85e6-6211b66c0318"), "Земельный участок" }
                });
        }
    }
}
