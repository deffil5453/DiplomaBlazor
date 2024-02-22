using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DiplomaRealEstate.Migrations
{
    /// <inheritdoc />
    public partial class _3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0857594b-a5ae-4a11-9f85-c6bc06c9784f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b7411f8b-ff4c-47ad-8394-f4aed5ef7690"));

            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: new Guid("ae81eff6-1873-4583-9e0b-6e47274773b0"));

            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: new Guid("fddd8db4-5dfd-4aad-956c-bb00196910b2"));

            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: new Guid("ff4de5d2-e1db-47c3-87cb-aaf88143f39d"));

            migrationBuilder.DeleteData(
                table: "TypeRealEstates",
                keyColumn: "Id",
                keyValue: new Guid("82a7177e-d8d7-426f-bc66-a16bdc741388"));

            migrationBuilder.DeleteData(
                table: "TypeRealEstates",
                keyColumn: "Id",
                keyValue: new Guid("af9f2a29-0151-4a83-ac4a-1d8c3d696fc0"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0857594b-a5ae-4a11-9f85-c6bc06c9784f"), "Жилая собственность" },
                    { new Guid("b7411f8b-ff4c-47ad-8394-f4aed5ef7690"), "Земельные участок" }
                });

            migrationBuilder.InsertData(
                table: "Statuses",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("ae81eff6-1873-4583-9e0b-6e47274773b0"), "Продано" },
                    { new Guid("fddd8db4-5dfd-4aad-956c-bb00196910b2"), "Активная" },
                    { new Guid("ff4de5d2-e1db-47c3-87cb-aaf88143f39d"), "Арендована" }
                });

            migrationBuilder.InsertData(
                table: "TypeRealEstates",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("82a7177e-d8d7-426f-bc66-a16bdc741388"), "Земельный участок" },
                    { new Guid("af9f2a29-0151-4a83-ac4a-1d8c3d696fc0"), "Дом " }
                });
        }
    }
}
