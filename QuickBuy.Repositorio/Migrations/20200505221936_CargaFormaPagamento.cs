﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace QuickBuy.Repositorio.Migrations
{
    public partial class CargaFormaPagamento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "FormasPagamentos",
                columns: new[] { "Id", "Descricao", "Nome" },
                values: new object[] { 1, "Forma Pagamento Boleto", "Boleto" });

            migrationBuilder.InsertData(
                table: "FormasPagamentos",
                columns: new[] { "Id", "Descricao", "Nome" },
                values: new object[] { 2, "Forma Pagamento Cartão de Credito", "Cartão de Crédito" });

            migrationBuilder.InsertData(
                table: "FormasPagamentos",
                columns: new[] { "Id", "Descricao", "Nome" },
                values: new object[] { 3, "Forma Pagamento Depósito", "Depósito" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FormasPagamentos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FormasPagamentos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "FormasPagamentos",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
