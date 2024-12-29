using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiCatalogo.Migrations
{
    
    public partial class PopulaProdutos : Migration
    {
        
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("INSERT INTO products (Name, Description, Price, ImageUrl, Quantity, DateCreated, CategoryId) VALUES('Carne', 'Carne FreeBoi', 33.90, 'Hamburguer.jpg', 2, now(), 2)");
            
        }

        
        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("DELETE FROM products");
        }
    }
}
