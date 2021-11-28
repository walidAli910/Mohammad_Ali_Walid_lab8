using Microsoft.EntityFrameworkCore.Migrations;

namespace Mohammad_Ali_Walid_lab8.Migrations
{
    public partial class BookCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PublisherID",
                table: "BookModel",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "CategoryModel",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryModel", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PublisherModel",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PublisherName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PublisherModel", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "BookCategoryModel",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookID = table.Column<int>(nullable: false),
                    CategoryID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookCategoryModel", x => x.ID);
                    table.ForeignKey(
                        name: "FK_BookCategoryModel_BookModel_BookID",
                        column: x => x.BookID,
                        principalTable: "BookModel",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookCategoryModel_CategoryModel_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "CategoryModel",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookModel_PublisherID",
                table: "BookModel",
                column: "PublisherID");

            migrationBuilder.CreateIndex(
                name: "IX_BookCategoryModel_BookID",
                table: "BookCategoryModel",
                column: "BookID");

            migrationBuilder.CreateIndex(
                name: "IX_BookCategoryModel_CategoryID",
                table: "BookCategoryModel",
                column: "CategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_BookModel_PublisherModel_PublisherID",
                table: "BookModel",
                column: "PublisherID",
                principalTable: "PublisherModel",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookModel_PublisherModel_PublisherID",
                table: "BookModel");

            migrationBuilder.DropTable(
                name: "BookCategoryModel");

            migrationBuilder.DropTable(
                name: "PublisherModel");

            migrationBuilder.DropTable(
                name: "CategoryModel");

            migrationBuilder.DropIndex(
                name: "IX_BookModel_PublisherID",
                table: "BookModel");

            migrationBuilder.DropColumn(
                name: "PublisherID",
                table: "BookModel");
        }
    }
}
