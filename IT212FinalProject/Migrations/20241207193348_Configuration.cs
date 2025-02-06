using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IT212FinalProject.Migrations
{
    /// <inheritdoc />
    public partial class Configuration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.ID);
                });
        }

        protected void AddSeedDataCustomer(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
            table: "Customers",
            columns: new[] { "ID", "FirstName", "LastName", "Email", "PhoneNumber" },
            values: new object[] { 1, "Mike", "Ross", "ContactMe@allowable.com", "360-888-8888" });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductsID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.ID);
                });
        }

            protected void AddSeedDataOrders(MigrationBuilder migrationBuilder)
            {
                migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "ID", "OrderNumber", "CustomerID", "ProductsID"},
                values: new object[] { 1, "1001", 1, 1 });

                migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductCategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UnitOfMeasure = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ID);
                });
        }
        protected void AddSeedDataProducts(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
            table: "Products",
            columns: new[] { "ID", "ProductName", "ProductDescription", "ProductCategoryName", "UnitOfMeasure" },
            values: new object[] { 1, "Slacks", "Wearable outer garment, lower body", "Pants", "Each" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");
        }

    }
}
