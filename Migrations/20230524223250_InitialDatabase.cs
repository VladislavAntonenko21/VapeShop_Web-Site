using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace VapeShopWebSite.Migrations
{
    /// <inheritdoc />
    public partial class InitialDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "liquids",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    amount_of_salt = table.Column<int>(type: "integer", nullable: false),
                    flavor = table.Column<string>(type: "text", nullable: true),
                    price = table.Column<int>(type: "integer", nullable: false),
                    brand = table.Column<string>(type: "text", nullable: true),
                    line = table.Column<string>(type: "text", nullable: true),
                    pgvg = table.Column<string>(type: "text", nullable: true),
                    volume = table.Column<int>(type: "integer", nullable: false),
                    whatnic = table.Column<string>(type: "text", nullable: true),
                    img1_src = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_liquids", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "liquids");
        }
    }
}
