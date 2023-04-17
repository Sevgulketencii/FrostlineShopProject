using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AboutDbSet",
                columns: table => new
                {
                    AboutID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AboutLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WorkingStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutMail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LinkedinUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GithupUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InstagramUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TwitterUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutDbSet", x => x.AboutID);
                });

            migrationBuilder.CreateTable(
                name: "CategoryDbSet",
                columns: table => new
                {
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryDbSet", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "ContactDbSet",
                columns: table => new
                {
                    ContactID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContactName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactMail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactDbSet", x => x.ContactID);
                });

            migrationBuilder.CreateTable(
                name: "FeatureDbSet",
                columns: table => new
                {
                    FeatureID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FeatureName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FeatureTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FeatureDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FeatureImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FeatureStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeatureDbSet", x => x.FeatureID);
                });

            migrationBuilder.CreateTable(
                name: "UserDbSet",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDbSet", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "DiscountDbSet",
                columns: table => new
                {
                    DiscountID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DiscountName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiscountImg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiscountRate = table.Column<int>(type: "int", nullable: false),
                    DiscountStatus = table.Column<bool>(type: "bit", nullable: false),
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiscountDbSet", x => x.DiscountID);
                    table.ForeignKey(
                        name: "FK_DiscountDbSet_CategoryDbSet_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "CategoryDbSet",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductDbSet",
                columns: table => new
                {
                    ProductID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductImageCover = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductImage2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductPrice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductStock = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductStatus = table.Column<bool>(type: "bit", nullable: false),
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductDbSet", x => x.ProductID);
                    table.ForeignKey(
                        name: "FK_ProductDbSet_CategoryDbSet_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "CategoryDbSet",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DiscountDbSet_CategoryID",
                table: "DiscountDbSet",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDbSet_CategoryID",
                table: "ProductDbSet",
                column: "CategoryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AboutDbSet");

            migrationBuilder.DropTable(
                name: "ContactDbSet");

            migrationBuilder.DropTable(
                name: "DiscountDbSet");

            migrationBuilder.DropTable(
                name: "FeatureDbSet");

            migrationBuilder.DropTable(
                name: "ProductDbSet");

            migrationBuilder.DropTable(
                name: "UserDbSet");

            migrationBuilder.DropTable(
                name: "CategoryDbSet");
        }
    }
}
