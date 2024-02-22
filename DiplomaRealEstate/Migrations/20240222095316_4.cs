using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DiplomaRealEstate.Migrations
{
    /// <inheritdoc />
    public partial class _4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a3025fde-2648-4990-84db-b31ad6b127f1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e2d6395c-f41b-48b9-b004-961b86a8d1ca"));

            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: new Guid("5b8e10ad-489c-4c4b-a043-6694ca7531fd"));

            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: new Guid("cedd5678-3edc-4f13-9600-2c9c93b2865b"));

            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: new Guid("fd7438ad-9a3c-486d-a2d9-2a9be9988d4c"));

            migrationBuilder.DeleteData(
                table: "TypeRealEstates",
                keyColumn: "Id",
                keyValue: new Guid("5b54c8f2-f42c-4e27-b22b-61f698ab5008"));

            migrationBuilder.DeleteData(
                table: "TypeRealEstates",
                keyColumn: "Id",
                keyValue: new Guid("ec4b7bf3-1edc-4c41-a26a-70f7d8ad2c01"));

            migrationBuilder.CreateTable(
                name: "CartItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RealEstateId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CartItems_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartItems_RealEstates_RealEstateId",
                        column: x => x.RealEstateId,
                        principalTable: "RealEstates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0c23eb8d-c031-4bb0-854a-2d5db8e3d1f4"), "Жилая собственность" },
                    { new Guid("89667dcf-1147-4a97-bd3d-4223232f69ac"), "Земельные участок" }
                });

            migrationBuilder.InsertData(
                table: "Statuses",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("83fc6fd9-dfe6-429e-946b-0796cd475ec6"), "Арендована" },
                    { new Guid("9f3a8e95-1af8-4958-a88f-d18381cc4682"), "Продано" },
                    { new Guid("a40dfecc-5be1-4f84-9b58-0a3db1d8dabf"), "Активная" }
                });

            migrationBuilder.InsertData(
                table: "TypeRealEstates",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("b91213af-4547-4e0d-b832-47927fb91fe2"), "Земельный участок" },
                    { new Guid("c6f7f568-e062-44d1-b343-223d3c87beb8"), "Дом " }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_RealEstateId",
                table: "CartItems",
                column: "RealEstateId");

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_UserId",
                table: "CartItems",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartItems");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0c23eb8d-c031-4bb0-854a-2d5db8e3d1f4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("89667dcf-1147-4a97-bd3d-4223232f69ac"));

            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: new Guid("83fc6fd9-dfe6-429e-946b-0796cd475ec6"));

            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: new Guid("9f3a8e95-1af8-4958-a88f-d18381cc4682"));

            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: new Guid("a40dfecc-5be1-4f84-9b58-0a3db1d8dabf"));

            migrationBuilder.DeleteData(
                table: "TypeRealEstates",
                keyColumn: "Id",
                keyValue: new Guid("b91213af-4547-4e0d-b832-47927fb91fe2"));

            migrationBuilder.DeleteData(
                table: "TypeRealEstates",
                keyColumn: "Id",
                keyValue: new Guid("c6f7f568-e062-44d1-b343-223d3c87beb8"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("a3025fde-2648-4990-84db-b31ad6b127f1"), "Земельные участок" },
                    { new Guid("e2d6395c-f41b-48b9-b004-961b86a8d1ca"), "Жилая собственность" }
                });

            migrationBuilder.InsertData(
                table: "Statuses",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("5b8e10ad-489c-4c4b-a043-6694ca7531fd"), "Активная" },
                    { new Guid("cedd5678-3edc-4f13-9600-2c9c93b2865b"), "Продано" },
                    { new Guid("fd7438ad-9a3c-486d-a2d9-2a9be9988d4c"), "Арендована" }
                });

            migrationBuilder.InsertData(
                table: "TypeRealEstates",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("5b54c8f2-f42c-4e27-b22b-61f698ab5008"), "Дом " },
                    { new Guid("ec4b7bf3-1edc-4c41-a26a-70f7d8ad2c01"), "Земельный участок" }
                });
        }
    }
}
