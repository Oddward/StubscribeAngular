using Microsoft.EntityFrameworkCore.Migrations;

namespace StubscribeAngular.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Colours",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colours", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SubCategories",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategories", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Subscriptions",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(nullable: true),
                    isActive = table.Column<bool>(nullable: false),
                    datetime_created = table.Column<string>(nullable: true),
                    datetime_next_renewal = table.Column<string>(nullable: true),
                    price = table.Column<float>(nullable: false),
                    PlanTypeId = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subscriptions", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "SubServices",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(nullable: true),
                    CategoryId = table.Column<int>(nullable: false),
                    logo_loc = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubServices", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(nullable: true),
                    default_card = table.Column<string>(nullable: true),
                    pass = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Values",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Values", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Members",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(nullable: true),
                    balance = table.Column<int>(nullable: false),
                    colour = table.Column<string>(nullable: true),
                    SubscriptionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Members", x => x.id);
                    table.ForeignKey(
                        name: "FK_Members_Subscriptions_SubscriptionId",
                        column: x => x.SubscriptionId,
                        principalTable: "Subscriptions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "name" },
                values: new object[] { 1, "white" });

            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "name" },
                values: new object[] { 2, "yellow" });

            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "name" },
                values: new object[] { 3, "blue" });

            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "name" },
                values: new object[] { 4, "purple" });

            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "name" },
                values: new object[] { 5, "silver" });

            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "name" },
                values: new object[] { 6, "brown" });

            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "name" },
                values: new object[] { 7, "green" });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "id", "name" },
                values: new object[] { 6, "Telecommunication" });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "id", "name" },
                values: new object[] { 5, "Courses" });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "id", "name" },
                values: new object[] { 4, "Transportation" });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "id", "name" },
                values: new object[] { 2, "Video streaming" });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "id", "name" },
                values: new object[] { 1, "Music streaming" });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "id", "name" },
                values: new object[] { 3, "Food delivery" });

            migrationBuilder.InsertData(
                table: "SubServices",
                columns: new[] { "id", "CategoryId", "logo_loc", "name" },
                values: new object[] { 3, 2, null, "Youtube Premium" });

            migrationBuilder.InsertData(
                table: "SubServices",
                columns: new[] { "id", "CategoryId", "logo_loc", "name" },
                values: new object[] { 1, 1, null, "Spotify" });

            migrationBuilder.InsertData(
                table: "SubServices",
                columns: new[] { "id", "CategoryId", "logo_loc", "name" },
                values: new object[] { 2, 2, null, "Netflix" });

            migrationBuilder.InsertData(
                table: "SubServices",
                columns: new[] { "id", "CategoryId", "logo_loc", "name" },
                values: new object[] { 4, 6, null, "Uni-fi" });

            migrationBuilder.CreateIndex(
                name: "IX_Members_SubscriptionId",
                table: "Members",
                column: "SubscriptionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Colours");

            migrationBuilder.DropTable(
                name: "Members");

            migrationBuilder.DropTable(
                name: "SubCategories");

            migrationBuilder.DropTable(
                name: "SubServices");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Values");

            migrationBuilder.DropTable(
                name: "Subscriptions");
        }
    }
}
