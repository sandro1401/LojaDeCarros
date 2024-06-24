﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LojaDeCarros.Migrations
{
    /// <inheritdoc />
    public partial class Clientemodel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Nota_Carro_CarroId",
                table: "Nota");

            migrationBuilder.DropForeignKey(
                name: "FK_Nota_Cliente_CompradorId",
                table: "Nota");

            migrationBuilder.RenameColumn(
                name: "CompradorId",
                table: "Nota",
                newName: "CompradorID");

            migrationBuilder.RenameColumn(
                name: "CarroId",
                table: "Nota",
                newName: "CarroID");

            migrationBuilder.RenameIndex(
                name: "IX_Nota_CompradorId",
                table: "Nota",
                newName: "IX_Nota_CompradorID");

            migrationBuilder.RenameIndex(
                name: "IX_Nota_CarroId",
                table: "Nota",
                newName: "IX_Nota_CarroID");

            migrationBuilder.RenameColumn(
                name: "telefone",
                table: "Cliente",
                newName: "Telefone");

            migrationBuilder.RenameColumn(
                name: "preco",
                table: "Carro",
                newName: "Preco");

            migrationBuilder.AddColumn<int>(
                name: "CarroId",
                table: "Cliente",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "Preco",
                table: "Carro",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<string>(
                name: "Modelo",
                table: "Carro",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Marca",
                table: "Carro",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "AnoModelo",
                table: "Carro",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_CarroId",
                table: "Cliente",
                column: "CarroId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cliente_Carro_CarroId",
                table: "Cliente",
                column: "CarroId",
                principalTable: "Carro",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Nota_Carro_CarroID",
                table: "Nota",
                column: "CarroID",
                principalTable: "Carro",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Nota_Cliente_CompradorID",
                table: "Nota",
                column: "CompradorID",
                principalTable: "Cliente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cliente_Carro_CarroId",
                table: "Cliente");

            migrationBuilder.DropForeignKey(
                name: "FK_Nota_Carro_CarroID",
                table: "Nota");

            migrationBuilder.DropForeignKey(
                name: "FK_Nota_Cliente_CompradorID",
                table: "Nota");

            migrationBuilder.DropIndex(
                name: "IX_Cliente_CarroId",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "CarroId",
                table: "Cliente");

            migrationBuilder.RenameColumn(
                name: "CompradorID",
                table: "Nota",
                newName: "CompradorId");

            migrationBuilder.RenameColumn(
                name: "CarroID",
                table: "Nota",
                newName: "CarroId");

            migrationBuilder.RenameIndex(
                name: "IX_Nota_CompradorID",
                table: "Nota",
                newName: "IX_Nota_CompradorId");

            migrationBuilder.RenameIndex(
                name: "IX_Nota_CarroID",
                table: "Nota",
                newName: "IX_Nota_CarroId");

            migrationBuilder.RenameColumn(
                name: "Telefone",
                table: "Cliente",
                newName: "telefone");

            migrationBuilder.RenameColumn(
                name: "Preco",
                table: "Carro",
                newName: "preco");

            migrationBuilder.AlterColumn<double>(
                name: "preco",
                table: "Carro",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Modelo",
                table: "Carro",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Marca",
                table: "Carro",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AnoModelo",
                table: "Carro",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddForeignKey(
                name: "FK_Nota_Carro_CarroId",
                table: "Nota",
                column: "CarroId",
                principalTable: "Carro",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Nota_Cliente_CompradorId",
                table: "Nota",
                column: "CompradorId",
                principalTable: "Cliente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}