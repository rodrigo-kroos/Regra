using Microsoft.EntityFrameworkCore.Migrations;

namespace Regra.Migrations
{
    public partial class PopularTabelas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome, Descricao) " +
                   "VALUES ('Cerveja', 'Mais vendidas')");

            migrationBuilder.Sql("INSERT INTO Cervejas(CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImagemThumbnaiUrl,ImagemUrl,IsCervejaPreferido,Nome,Preco)" +
             " VALUES((SELECT CategoriaId FROM Categorias Where CategoriaNome='Cerveja'),'Cerveja Budweiser', 'Cerveja budweiser Lata 269 contém 12 unidades unidades', 1, 'https://cdn.awsli.com.br/600x450/1061/1061010/produto/41608932/aaafe07c8b.jpg'," +
             "'https://cdn.awsli.com.br/600x450/1061/1061010/produto/41608932/aaafe07c8b.jpg', 0 ,'Budweiser 269 ml', 3.00)");


            migrationBuilder.Sql("INSERT INTO Cervejas(CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImagemThumbnaiUrl,ImagemUrl,IsCervejaPreferido,Nome,Preco)" +
               " VALUES((SELECT CategoriaId FROM Categorias Where CategoriaNome='Cerveja'),'Skol Lata', 'Cerveja Skol Lata 269 ml contém 12 unidades unidades', 1, 'https://s3-sa-east-1.amazonaws.com/bluesoft-erp/semar/ecommerce/produtos/fotos/d8d4c803-2ba5-47b1-8597-a42e1a23776d/foto_small.jpgbra'," +
               "'https://s3-sa-east-1.amazonaws.com/bluesoft-erp/semar/ecommerce/produtos/fotos/d8d4c803-2ba5-47b1-8597-a42e1a23776d/foto_small.jpg', 0 ,'Skol Lata', 2.50)");

            migrationBuilder.Sql("INSERT INTO Cervejas(CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImagemThumbnaiUrl,ImagemUrl,IsCervejaPreferido,Nome,Preco)" +
             " VALUES((SELECT CategoriaId FROM Categorias Where CategoriaNome='Cerveja'),'Brahma Chopp', 'Brahma Chopp lata 269 ml contém 6 unidades unidades', 1, 'https://www.maischopp.com.br/wp-content/uploads/2021/03/7891149010509.png'," +
               "'https://www.maischopp.com.br/wp-content/uploads/2021/03/7891149010509.png', 0, 'Brahma Chopp', 3.00)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
