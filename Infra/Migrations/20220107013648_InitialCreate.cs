using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infra.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "addresses",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    InsertDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    ZipCode = table.Column<string>(type: "varchar(256)", nullable: true),
                    Street = table.Column<string>(type: "varchar(256)", nullable: true),
                    Number = table.Column<string>(type: "varchar(256)", nullable: true),
                    Complement = table.Column<string>(type: "varchar(256)", nullable: true),
                    Reference = table.Column<string>(type: "varchar(256)", nullable: true),
                    Neighborhood = table.Column<string>(type: "varchar(256)", nullable: true),
                    City = table.Column<string>(type: "varchar(256)", nullable: true),
                    State = table.Column<string>(type: "varchar(256)", nullable: true),
                    SupplierGuid = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_addresses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    InsertDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(type: "varchar(256)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "emails",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    InsertDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    EmailAddress = table.Column<string>(type: "varchar(256)", nullable: false),
                    SupplierGuid = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_emails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "imagems",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    InsertDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    ImagePath = table.Column<string>(type: "varchar(256)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_imagems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    InsertDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    emailID = table.Column<Guid>(nullable: false),
                    addressID = table.Column<Guid>(nullable: false),
                    Discriminator = table.Column<string>(type: "varchar(256)", nullable: false),
                    CompanyName = table.Column<string>(type: "varchar(256)", nullable: true),
                    FantasyName = table.Column<string>(type: "varchar(256)", nullable: true),
                    Cnpj = table.Column<string>(type: "varchar(256)", nullable: true),
                    OpenDate = table.Column<DateTime>(nullable: true),
                    SupplierPhysical_FantasyName = table.Column<string>(type: "varchar(256)", nullable: true),
                    Name = table.Column<string>(type: "varchar(256)", nullable: true),
                    cpf = table.Column<string>(type: "varchar(256)", nullable: true),
                    BirthDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Suppliers_addresses_addressID",
                        column: x => x.addressID,
                        principalTable: "addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Suppliers_emails_emailID",
                        column: x => x.emailID,
                        principalTable: "emails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "phones",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    InsertDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    Ddd = table.Column<string>(type: "varchar(256)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "varchar(256)", nullable: true),
                    supplierID = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_phones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_phones_Suppliers_supplierID",
                        column: x => x.supplierID,
                        principalTable: "Suppliers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    InsertDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(type: "varchar(256)", nullable: true),
                    BarCode = table.Column<string>(type: "varchar(256)", nullable: true),
                    QuantityStock = table.Column<int>(nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    PriceSales = table.Column<decimal>(nullable: false),
                    PricePurchase = table.Column<decimal>(nullable: false),
                    categoryID = table.Column<Guid>(nullable: false),
                    supplierID = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_categories_categoryID",
                        column: x => x.categoryID,
                        principalTable: "categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_Suppliers_supplierID",
                        column: x => x.supplierID,
                        principalTable: "Suppliers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_phones_supplierID",
                table: "phones",
                column: "supplierID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_categoryID",
                table: "Products",
                column: "categoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_supplierID",
                table: "Products",
                column: "supplierID");

            migrationBuilder.CreateIndex(
                name: "IX_Suppliers_addressID",
                table: "Suppliers",
                column: "addressID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Suppliers_emailID",
                table: "Suppliers",
                column: "emailID",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "imagems");

            migrationBuilder.DropTable(
                name: "phones");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "categories");

            migrationBuilder.DropTable(
                name: "Suppliers");

            migrationBuilder.DropTable(
                name: "addresses");

            migrationBuilder.DropTable(
                name: "emails");
        }
    }
}
