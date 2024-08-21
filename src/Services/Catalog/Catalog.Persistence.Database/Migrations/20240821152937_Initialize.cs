using Microsoft.EntityFrameworkCore.Migrations;

namespace Catalog.Persistence.Database.Migrations
{
    public partial class Initialize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "catalog");

            migrationBuilder.CreateTable(
                name: "Products",
                schema: "catalog",
                columns: table => new
                {
                    ProductID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 150, nullable: false),
                    Description = table.Column<string>(maxLength: 500, nullable: true),
                    Price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductID);
                });

            migrationBuilder.CreateTable(
                name: "Stocks",
                schema: "catalog",
                columns: table => new
                {
                    ProductInStockId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(nullable: false),
                    Stock = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stocks", x => x.ProductInStockId);
                    table.ForeignKey(
                        name: "FK_Stocks_Products_ProductId",
                        column: x => x.ProductId,
                        principalSchema: "catalog",
                        principalTable: "Products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "catalog",
                table: "Products",
                columns: new[] { "ProductID", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Product 1 Description", "Product 1", 61250m },
                    { 73, "Product 73 Description", "Product 73", 20176m },
                    { 72, "Product 72 Description", "Product 72", 38295m },
                    { 71, "Product 71 Description", "Product 71", 65953m },
                    { 70, "Product 70 Description", "Product 70", 39487m },
                    { 69, "Product 69 Description", "Product 69", 39388m },
                    { 68, "Product 68 Description", "Product 68", 43317m },
                    { 67, "Product 67 Description", "Product 67", 92496m },
                    { 66, "Product 66 Description", "Product 66", 30550m },
                    { 65, "Product 65 Description", "Product 65", 84200m },
                    { 64, "Product 64 Description", "Product 64", 96671m },
                    { 63, "Product 63 Description", "Product 63", 73488m },
                    { 62, "Product 62 Description", "Product 62", 47449m },
                    { 61, "Product 61 Description", "Product 61", 18305m },
                    { 60, "Product 60 Description", "Product 60", 42819m },
                    { 59, "Product 59 Description", "Product 59", 78782m },
                    { 58, "Product 58 Description", "Product 58", 91657m },
                    { 57, "Product 57 Description", "Product 57", 81890m },
                    { 56, "Product 56 Description", "Product 56", 74090m },
                    { 55, "Product 55 Description", "Product 55", 48143m },
                    { 54, "Product 54 Description", "Product 54", 30227m },
                    { 53, "Product 53 Description", "Product 53", 95006m },
                    { 74, "Product 74 Description", "Product 74", 24579m },
                    { 52, "Product 52 Description", "Product 52", 71817m },
                    { 75, "Product 75 Description", "Product 75", 41641m },
                    { 77, "Product 77 Description", "Product 77", 12374m },
                    { 98, "Product 98 Description", "Product 98", 88113m },
                    { 97, "Product 97 Description", "Product 97", 91148m },
                    { 96, "Product 96 Description", "Product 96", 14367m },
                    { 95, "Product 95 Description", "Product 95", 94962m },
                    { 94, "Product 94 Description", "Product 94", 31855m },
                    { 93, "Product 93 Description", "Product 93", 10302m },
                    { 92, "Product 92 Description", "Product 92", 17026m },
                    { 91, "Product 91 Description", "Product 91", 82654m },
                    { 90, "Product 90 Description", "Product 90", 65830m },
                    { 89, "Product 89 Description", "Product 89", 15222m },
                    { 88, "Product 88 Description", "Product 88", 32699m },
                    { 87, "Product 87 Description", "Product 87", 18533m },
                    { 86, "Product 86 Description", "Product 86", 97846m },
                    { 85, "Product 85 Description", "Product 85", 27027m },
                    { 84, "Product 84 Description", "Product 84", 75263m },
                    { 83, "Product 83 Description", "Product 83", 45383m },
                    { 82, "Product 82 Description", "Product 82", 60964m },
                    { 81, "Product 81 Description", "Product 81", 48371m },
                    { 80, "Product 80 Description", "Product 80", 12609m },
                    { 79, "Product 79 Description", "Product 79", 29940m },
                    { 78, "Product 78 Description", "Product 78", 31786m },
                    { 76, "Product 76 Description", "Product 76", 89120m },
                    { 51, "Product 51 Description", "Product 51", 95083m },
                    { 50, "Product 50 Description", "Product 50", 40224m },
                    { 49, "Product 49 Description", "Product 49", 17255m },
                    { 22, "Product 22 Description", "Product 22", 87159m },
                    { 21, "Product 21 Description", "Product 21", 53758m },
                    { 20, "Product 20 Description", "Product 20", 83458m },
                    { 19, "Product 19 Description", "Product 19", 27848m },
                    { 18, "Product 18 Description", "Product 18", 74852m },
                    { 17, "Product 17 Description", "Product 17", 17380m },
                    { 16, "Product 16 Description", "Product 16", 64637m },
                    { 15, "Product 15 Description", "Product 15", 94031m },
                    { 14, "Product 14 Description", "Product 14", 69309m },
                    { 13, "Product 13 Description", "Product 13", 86683m },
                    { 12, "Product 12 Description", "Product 12", 45424m },
                    { 11, "Product 11 Description", "Product 11", 34089m },
                    { 10, "Product 10 Description", "Product 10", 53864m },
                    { 9, "Product 9 Description", "Product 9", 18782m },
                    { 8, "Product 8 Description", "Product 8", 78976m },
                    { 7, "Product 7 Description", "Product 7", 90089m },
                    { 6, "Product 6 Description", "Product 6", 21308m },
                    { 5, "Product 5 Description", "Product 5", 90845m },
                    { 4, "Product 4 Description", "Product 4", 59381m },
                    { 3, "Product 3 Description", "Product 3", 91083m },
                    { 2, "Product 2 Description", "Product 2", 89444m },
                    { 23, "Product 23 Description", "Product 23", 17553m },
                    { 24, "Product 24 Description", "Product 24", 99425m },
                    { 25, "Product 25 Description", "Product 25", 80598m },
                    { 26, "Product 26 Description", "Product 26", 58025m },
                    { 48, "Product 48 Description", "Product 48", 52038m },
                    { 47, "Product 47 Description", "Product 47", 19654m },
                    { 46, "Product 46 Description", "Product 46", 77988m },
                    { 45, "Product 45 Description", "Product 45", 79484m },
                    { 44, "Product 44 Description", "Product 44", 85767m },
                    { 43, "Product 43 Description", "Product 43", 84785m },
                    { 42, "Product 42 Description", "Product 42", 64637m },
                    { 41, "Product 41 Description", "Product 41", 51817m },
                    { 40, "Product 40 Description", "Product 40", 13268m },
                    { 39, "Product 39 Description", "Product 39", 64675m },
                    { 99, "Product 99 Description", "Product 99", 11566m },
                    { 38, "Product 38 Description", "Product 38", 79085m },
                    { 36, "Product 36 Description", "Product 36", 64544m },
                    { 35, "Product 35 Description", "Product 35", 39921m },
                    { 34, "Product 34 Description", "Product 34", 53365m },
                    { 33, "Product 33 Description", "Product 33", 52927m },
                    { 32, "Product 32 Description", "Product 32", 13539m },
                    { 31, "Product 31 Description", "Product 31", 69664m },
                    { 30, "Product 30 Description", "Product 30", 22110m },
                    { 29, "Product 29 Description", "Product 29", 15487m },
                    { 28, "Product 28 Description", "Product 28", 52639m },
                    { 27, "Product 27 Description", "Product 27", 13002m },
                    { 37, "Product 37 Description", "Product 37", 98684m },
                    { 100, "Product 100 Description", "Product 100", 58934m }
                });

            migrationBuilder.InsertData(
                schema: "catalog",
                table: "Stocks",
                columns: new[] { "ProductInStockId", "ProductId", "Stock" },
                values: new object[,]
                {
                    { 1, 1, 78 },
                    { 73, 73, 4 },
                    { 72, 72, 19 },
                    { 71, 71, 25 },
                    { 70, 70, 97 },
                    { 69, 69, 13 },
                    { 68, 68, 16 },
                    { 67, 67, 33 },
                    { 66, 66, 33 },
                    { 65, 65, 41 },
                    { 64, 64, 36 },
                    { 63, 63, 4 },
                    { 62, 62, 69 },
                    { 61, 61, 76 },
                    { 60, 60, 91 },
                    { 59, 59, 95 },
                    { 58, 58, 11 },
                    { 57, 57, 72 },
                    { 56, 56, 65 },
                    { 55, 55, 84 },
                    { 54, 54, 87 },
                    { 53, 53, 2 },
                    { 74, 74, 12 },
                    { 52, 52, 93 },
                    { 75, 75, 61 },
                    { 77, 77, 72 },
                    { 98, 98, 3 },
                    { 97, 97, 18 },
                    { 96, 96, 95 },
                    { 95, 95, 60 },
                    { 94, 94, 33 },
                    { 93, 93, 9 },
                    { 92, 92, 29 },
                    { 91, 91, 63 },
                    { 90, 90, 96 },
                    { 89, 89, 51 },
                    { 88, 88, 29 },
                    { 87, 87, 54 },
                    { 86, 86, 69 },
                    { 85, 85, 33 },
                    { 84, 84, 18 },
                    { 83, 83, 34 },
                    { 82, 82, 42 },
                    { 81, 81, 4 },
                    { 80, 80, 32 },
                    { 79, 79, 36 },
                    { 78, 78, 48 },
                    { 76, 76, 29 },
                    { 51, 51, 30 },
                    { 50, 50, 42 },
                    { 49, 49, 87 },
                    { 22, 22, 12 },
                    { 21, 21, 52 },
                    { 20, 20, 27 },
                    { 19, 19, 50 },
                    { 18, 18, 29 },
                    { 17, 17, 23 },
                    { 16, 16, 66 },
                    { 15, 15, 33 },
                    { 14, 14, 75 },
                    { 13, 13, 53 },
                    { 12, 12, 51 },
                    { 11, 11, 90 },
                    { 10, 10, 4 },
                    { 9, 9, 0 },
                    { 8, 8, 65 },
                    { 7, 7, 91 },
                    { 6, 6, 0 },
                    { 5, 5, 20 },
                    { 4, 4, 3 },
                    { 3, 3, 86 },
                    { 2, 2, 41 },
                    { 23, 23, 69 },
                    { 24, 24, 74 },
                    { 25, 25, 7 },
                    { 26, 26, 29 },
                    { 48, 48, 82 },
                    { 47, 47, 24 },
                    { 46, 46, 75 },
                    { 45, 45, 38 },
                    { 44, 44, 21 },
                    { 43, 43, 40 },
                    { 42, 42, 23 },
                    { 41, 41, 65 },
                    { 40, 40, 37 },
                    { 39, 39, 24 },
                    { 99, 99, 79 },
                    { 38, 38, 4 },
                    { 36, 36, 35 },
                    { 35, 35, 62 },
                    { 34, 34, 36 },
                    { 33, 33, 17 },
                    { 32, 32, 56 },
                    { 31, 31, 62 },
                    { 30, 30, 63 },
                    { 29, 29, 61 },
                    { 28, 28, 21 },
                    { 27, 27, 24 },
                    { 37, 37, 40 },
                    { 100, 100, 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductID",
                schema: "catalog",
                table: "Products",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_ProductId",
                schema: "catalog",
                table: "Stocks",
                column: "ProductId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stocks",
                schema: "catalog");

            migrationBuilder.DropTable(
                name: "Products",
                schema: "catalog");
        }
    }
}
