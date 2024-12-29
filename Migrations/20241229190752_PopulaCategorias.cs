using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiCatalogo.Migrations
{
    
    public partial class PopulaCategorias : Migration
    {
        
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("INSERT INTO Categories(Name, ImageUrl) VALUES ('Bebidas', 'Bebidas.jpg')");
            mb.Sql("INSERT INTO Categories(Name, ImageUrl) VALUES ('Lanches', 'lanches.jpg')");
            mb.Sql("INSERT INTO Categories(Name, ImageUrl) VALUES ('Sobremesas', 'Sobremesas.jpg')");
        }

        
        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("DELETE FROM Categories");
        }
    }
}
