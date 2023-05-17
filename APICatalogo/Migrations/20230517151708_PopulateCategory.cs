using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICatalogo.Migrations
{
    /// <inheritdoc />
    public partial class PopulateCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("insert into categories(Name, ImageUrl) values('Bebidas', 'bebidas.jpg')");
            migrationBuilder.Sql("insert into categories(Name, ImageUrl) values('Lanches', 'lanches.jpg')");
            migrationBuilder.Sql("insert into categories(Name, ImageUrl) values('Sobremesas', 'sobremesas.jpg')");
		}

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("delete from categories");

		}
    }
}
