using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LojaDeCarros.Migrations
{
    /// <inheritdoc />
    public partial class alteraModelsNota : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NotaId",
                table: "Seller",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NotaId",
                table: "Cliente",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NotaId",
                table: "Carro",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Seller_NotaId",
                table: "Seller",
                column: "NotaId");

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_NotaId",
                table: "Cliente",
                column: "NotaId");

            migrationBuilder.CreateIndex(
                name: "IX_Carro_NotaId",
                table: "Carro",
                column: "NotaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Carro_Nota_NotaId",
                table: "Carro",
                column: "NotaId",
                principalTable: "Nota",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Cliente_Nota_NotaId",
                table: "Cliente",
                column: "NotaId",
                principalTable: "Nota",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Seller_Nota_NotaId",
                table: "Seller",
                column: "NotaId",
                principalTable: "Nota",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carro_Nota_NotaId",
                table: "Carro");

            migrationBuilder.DropForeignKey(
                name: "FK_Cliente_Nota_NotaId",
                table: "Cliente");

            migrationBuilder.DropForeignKey(
                name: "FK_Seller_Nota_NotaId",
                table: "Seller");

            migrationBuilder.DropIndex(
                name: "IX_Seller_NotaId",
                table: "Seller");

            migrationBuilder.DropIndex(
                name: "IX_Cliente_NotaId",
                table: "Cliente");

            migrationBuilder.DropIndex(
                name: "IX_Carro_NotaId",
                table: "Carro");

            migrationBuilder.DropColumn(
                name: "NotaId",
                table: "Seller");

            migrationBuilder.DropColumn(
                name: "NotaId",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "NotaId",
                table: "Carro");
        }
    }
}
