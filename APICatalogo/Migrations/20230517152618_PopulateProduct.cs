using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICatalogo.Migrations
{
    /// <inheritdoc />
    public partial class PopulateProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("insert into products(Name, Description, Price, ImageUrl, Stock, RegistrationDate, CategoryId) " +
                "values('Coca-Cola Diet', 'Refrigerante de cola 350 ml', 5.45, 'cocacola.jpg', 50, now(), 1)");
			migrationBuilder.Sql("insert into products(Name, Description, Price, ImageUrl, Stock, RegistrationDate, CategoryId) " +
				"values('Lanche de Atum', 'Lanche de atum com maionese', 8.50, 'atum.jpg', 10, now(), 2)");
			migrationBuilder.Sql("insert into products(Name, Description, Price, ImageUrl, Stock, RegistrationDate, CategoryId) " +
				"values('Pudim', 'Pudim de leite condensado 100 g', 6.75, 'pudim.jpg', 20, now(), 3)");
		}

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("delete from products");

		}
    }
}
