using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DiplomaRealEstate.Migrations
{
	/// <inheritdoc />
	public partial class _1 : Migration
	{
		/// <inheritdoc />
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.CreateTable(
				name: "AspNetRoles",
				columns: table => new
				{
					Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
					Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
					NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
					ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_AspNetRoles", x => x.Id);
				});

			migrationBuilder.CreateTable(
				name: "AspNetUsers",
				columns: table => new
				{
					Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
					LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
					FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
					MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
					UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
					NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
					Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
					NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
					EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
					PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
					SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
					ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
					PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
					PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
					TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
					LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
					LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
					AccessFailedCount = table.Column<int>(type: "int", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_AspNetUsers", x => x.Id);
				});

			migrationBuilder.CreateTable(
				name: "Categories",
				columns: table => new
				{
					Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
					Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Categories", x => x.Id);
				});

			migrationBuilder.CreateTable(
				name: "Statuses",
				columns: table => new
				{
					Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
					Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Statuses", x => x.Id);
				});

			migrationBuilder.CreateTable(
				name: "TypeRealEstates",
				columns: table => new
				{
					Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
					Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_TypeRealEstates", x => x.Id);
				});

			migrationBuilder.CreateTable(
				name: "TypeTransactions",
				columns: table => new
				{
					Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
					Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_TypeTransactions", x => x.Id);
				});

			migrationBuilder.CreateTable(
				name: "AspNetRoleClaims",
				columns: table => new
				{
					Id = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
					ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
					ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
					table.ForeignKey(
						name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
						column: x => x.RoleId,
						principalTable: "AspNetRoles",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
				});

			migrationBuilder.CreateTable(
				name: "AspNetUserClaims",
				columns: table => new
				{
					Id = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
					ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
					ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
					table.ForeignKey(
						name: "FK_AspNetUserClaims_AspNetUsers_UserId",
						column: x => x.UserId,
						principalTable: "AspNetUsers",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
				});

			migrationBuilder.CreateTable(
				name: "AspNetUserLogins",
				columns: table => new
				{
					LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
					ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
					ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
					UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
					table.ForeignKey(
						name: "FK_AspNetUserLogins_AspNetUsers_UserId",
						column: x => x.UserId,
						principalTable: "AspNetUsers",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
				});

			migrationBuilder.CreateTable(
				name: "AspNetUserRoles",
				columns: table => new
				{
					UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
					RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
					table.ForeignKey(
						name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
						column: x => x.RoleId,
						principalTable: "AspNetRoles",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
					table.ForeignKey(
						name: "FK_AspNetUserRoles_AspNetUsers_UserId",
						column: x => x.UserId,
						principalTable: "AspNetUsers",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
				});

			migrationBuilder.CreateTable(
				name: "AspNetUserTokens",
				columns: table => new
				{
					UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
					LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
					Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
					Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
					table.ForeignKey(
						name: "FK_AspNetUserTokens_AspNetUsers_UserId",
						column: x => x.UserId,
						principalTable: "AspNetUsers",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
				});

			migrationBuilder.CreateTable(
				name: "Reviews",
				columns: table => new
				{
					Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
					UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
					text = table.Column<string>(type: "nvarchar(max)", nullable: false),
					Rating = table.Column<int>(type: "int", nullable: false),
					RealEstateId = table.Column<string>(type: "nvarchar(max)", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Reviews", x => x.Id);
					table.ForeignKey(
						name: "FK_Reviews_AspNetUsers_UserId",
						column: x => x.UserId,
						principalTable: "AspNetUsers",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
				});

			migrationBuilder.CreateTable(
				name: "RealEstates",
				columns: table => new
				{
					Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
					Area = table.Column<string>(type: "nvarchar(max)", nullable: false),
					Price = table.Column<int>(type: "int", nullable: false),
					Rooms = table.Column<int>(type: "int", nullable: false),
					Desctiption = table.Column<string>(type: "nvarchar(max)", nullable: true),
					Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
					Region = table.Column<string>(type: "nvarchar(max)", nullable: false),
					City = table.Column<string>(type: "nvarchar(max)", nullable: true),
					Street = table.Column<string>(type: "nvarchar(max)", nullable: true),
					House = table.Column<string>(type: "nvarchar(max)", nullable: true),
					Latitude = table.Column<string>(type: "nvarchar(max)", nullable: false),
					Longitude = table.Column<string>(type: "nvarchar(max)", nullable: false),
					Photos = table.Column<string>(type: "nvarchar(max)", nullable: false),
					UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
					TypeRealEstateId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
					StatusId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
					CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
					ReviewId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_RealEstates", x => x.Id);
					table.ForeignKey(
						name: "FK_RealEstates_AspNetUsers_UserId",
						column: x => x.UserId,
						principalTable: "AspNetUsers",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
					table.ForeignKey(
						name: "FK_RealEstates_Categories_CategoryId",
						column: x => x.CategoryId,
						principalTable: "Categories",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
					table.ForeignKey(
						name: "FK_RealEstates_Reviews_ReviewId",
						column: x => x.ReviewId,
						principalTable: "Reviews",
						principalColumn: "Id");
					table.ForeignKey(
						name: "FK_RealEstates_Statuses_StatusId",
						column: x => x.StatusId,
						principalTable: "Statuses",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
					table.ForeignKey(
						name: "FK_RealEstates_TypeRealEstates_TypeRealEstateId",
						column: x => x.TypeRealEstateId,
						principalTable: "TypeRealEstates",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
				});

			migrationBuilder.CreateTable(
				name: "FavoriteRealEstates",
				columns: table => new
				{
					Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
					RealEstateId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
					UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_FavoriteRealEstates", x => x.Id);
					table.ForeignKey(
						name: "FK_FavoriteRealEstates_AspNetUsers_UserId",
						column: x => x.UserId,
						principalTable: "AspNetUsers",
						principalColumn: "Id");
					table.ForeignKey(
						name: "FK_FavoriteRealEstates_RealEstates_RealEstateId",
						column: x => x.RealEstateId,
						principalTable: "RealEstates",
						principalColumn: "Id");
				});

			migrationBuilder.CreateTable(
				name: "TransactionOrders",
				columns: table => new
				{
					Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
					TypeTransactionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
					RealEstateId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
					SellerId = table.Column<string>(type: "nvarchar(max)", nullable: false),
					CustomerId = table.Column<string>(type: "nvarchar(max)", nullable: false),
					UserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_TransactionOrders", x => x.Id);
					table.ForeignKey(
						name: "FK_TransactionOrders_AspNetUsers_UserId",
						column: x => x.UserId,
						principalTable: "AspNetUsers",
						principalColumn: "Id");
					table.ForeignKey(
						name: "FK_TransactionOrders_RealEstates_RealEstateId",
						column: x => x.RealEstateId,
						principalTable: "RealEstates",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
					table.ForeignKey(
						name: "FK_TransactionOrders_TypeTransactions_TypeTransactionId",
						column: x => x.TypeTransactionId,
						principalTable: "TypeTransactions",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
				});

			migrationBuilder.InsertData(
				table: "Categories",
				columns: new[] { "Id", "Name" },
				values: new object[,]
				{
					{ new Guid("55332440-91c3-46f1-9b56-109a1e453227"), "Жилая собственность" },
					{ new Guid("76fbaf2a-5dcf-4428-b380-2ed6516f42be"), "Земельные участок" }
				});

			migrationBuilder.InsertData(
				table: "Statuses",
				columns: new[] { "Id", "Name" },
				values: new object[,]
				{
					{ new Guid("221dd4bc-3561-412b-b5bd-f62052338d1e"), "Активная" },
					{ new Guid("93677f56-506e-472a-bb77-afc2f78b1eb4"), "Арендована" },
					{ new Guid("ac4ef776-6f4e-49bf-b7c3-6e7c155c6efd"), "Продано" }
				});

			migrationBuilder.InsertData(
				table: "TypeRealEstates",
				columns: new[] { "Id", "Name" },
				values: new object[,]
				{
					{ new Guid("6ce267a7-27b2-4407-9d43-5ac88da34a7e"), "Земельный участок" },
					{ new Guid("6e998e77-b92a-4594-b163-0f8308df0b8c"), "Дом " }
				});

			migrationBuilder.InsertData(
				table: "TypeTransactions",
				columns: new[] { "Id", "Name" },
				values: new object[,]
				{
					{ new Guid("224ab08d-fd39-4491-b12b-8a29faa59bd4"), "Аренда" },
					{ new Guid("95434834-70b4-4133-82b0-2c62556b4333"), "Покупка" },
					{ new Guid("a1f96f38-ea01-4494-83d2-41ca6d39355c"), "Продажа" }
				});

			migrationBuilder.CreateIndex(
				name: "IX_AspNetRoleClaims_RoleId",
				table: "AspNetRoleClaims",
				column: "RoleId");

			migrationBuilder.CreateIndex(
				name: "RoleNameIndex",
				table: "AspNetRoles",
				column: "NormalizedName",
				unique: true,
				filter: "[NormalizedName] IS NOT NULL");

			migrationBuilder.CreateIndex(
				name: "IX_AspNetUserClaims_UserId",
				table: "AspNetUserClaims",
				column: "UserId");

			migrationBuilder.CreateIndex(
				name: "IX_AspNetUserLogins_UserId",
				table: "AspNetUserLogins",
				column: "UserId");

			migrationBuilder.CreateIndex(
				name: "IX_AspNetUserRoles_RoleId",
				table: "AspNetUserRoles",
				column: "RoleId");

			migrationBuilder.CreateIndex(
				name: "EmailIndex",
				table: "AspNetUsers",
				column: "NormalizedEmail");

			migrationBuilder.CreateIndex(
				name: "UserNameIndex",
				table: "AspNetUsers",
				column: "NormalizedUserName",
				unique: true,
				filter: "[NormalizedUserName] IS NOT NULL");

			migrationBuilder.CreateIndex(
				name: "IX_FavoriteRealEstates_RealEstateId",
				table: "FavoriteRealEstates",
				column: "RealEstateId");

			migrationBuilder.CreateIndex(
				name: "IX_FavoriteRealEstates_UserId",
				table: "FavoriteRealEstates",
				column: "UserId");

			migrationBuilder.CreateIndex(
				name: "IX_RealEstates_CategoryId",
				table: "RealEstates",
				column: "CategoryId");

			migrationBuilder.CreateIndex(
				name: "IX_RealEstates_ReviewId",
				table: "RealEstates",
				column: "ReviewId");

			migrationBuilder.CreateIndex(
				name: "IX_RealEstates_StatusId",
				table: "RealEstates",
				column: "StatusId");

			migrationBuilder.CreateIndex(
				name: "IX_RealEstates_TypeRealEstateId",
				table: "RealEstates",
				column: "TypeRealEstateId");

			migrationBuilder.CreateIndex(
				name: "IX_RealEstates_UserId",
				table: "RealEstates",
				column: "UserId");

			migrationBuilder.CreateIndex(
				name: "IX_Reviews_UserId",
				table: "Reviews",
				column: "UserId");

			migrationBuilder.CreateIndex(
				name: "IX_TransactionOrders_RealEstateId",
				table: "TransactionOrders",
				column: "RealEstateId");

			migrationBuilder.CreateIndex(
				name: "IX_TransactionOrders_TypeTransactionId",
				table: "TransactionOrders",
				column: "TypeTransactionId");

			migrationBuilder.CreateIndex(
				name: "IX_TransactionOrders_UserId",
				table: "TransactionOrders",
				column: "UserId");
		}

		/// <inheritdoc />
		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropTable(
				name: "AspNetRoleClaims");

			migrationBuilder.DropTable(
				name: "AspNetUserClaims");

			migrationBuilder.DropTable(
				name: "AspNetUserLogins");

			migrationBuilder.DropTable(
				name: "AspNetUserRoles");

			migrationBuilder.DropTable(
				name: "AspNetUserTokens");

			migrationBuilder.DropTable(
				name: "FavoriteRealEstates");

			migrationBuilder.DropTable(
				name: "TransactionOrders");

			migrationBuilder.DropTable(
				name: "AspNetRoles");

			migrationBuilder.DropTable(
				name: "RealEstates");

			migrationBuilder.DropTable(
				name: "TypeTransactions");

			migrationBuilder.DropTable(
				name: "Categories");

			migrationBuilder.DropTable(
				name: "Reviews");

			migrationBuilder.DropTable(
				name: "Statuses");

			migrationBuilder.DropTable(
				name: "TypeRealEstates");

			migrationBuilder.DropTable(
				name: "AspNetUsers");
		}
	}
}
