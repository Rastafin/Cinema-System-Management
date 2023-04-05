using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KinoProjekt.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DbKlient",
                columns: table => new
                {
                    IdKlient = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    StanKonta = table.Column<double>(type: "REAL", nullable: false),
                    Imie = table.Column<string>(type: "TEXT", nullable: false),
                    Nazwisko = table.Column<string>(type: "TEXT", nullable: false),
                    DataUrodzenia = table.Column<string>(type: "TEXT", nullable: false),
                    Plec = table.Column<string>(type: "TEXT", nullable: false),
                    Haslo = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    NrTelefonu = table.Column<string>(type: "TEXT", nullable: false),
                    Wojewodztwo = table.Column<int>(type: "INTEGER", nullable: false),
                    Miasto = table.Column<string>(type: "TEXT", nullable: false),
                    Ulica = table.Column<string>(type: "TEXT", nullable: false),
                    NrDomu = table.Column<string>(type: "TEXT", nullable: false),
                    NrMieszkania = table.Column<string>(type: "TEXT", nullable: false),
                    KodPocztowy = table.Column<string>(type: "TEXT", nullable: false),
                    CzyKlient = table.Column<bool>(type: "INTEGER", nullable: false),
                    CzyZarchiwizowany = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DbKlient", x => x.IdKlient);
                });

            migrationBuilder.CreateTable(
                name: "DbPracownik",
                columns: table => new
                {
                    IdPracownik = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    StopienUprawnienia = table.Column<int>(type: "INTEGER", nullable: false),
                    Imie = table.Column<string>(type: "TEXT", nullable: false),
                    Nazwisko = table.Column<string>(type: "TEXT", nullable: false),
                    DataUrodzenia = table.Column<string>(type: "TEXT", nullable: false),
                    Plec = table.Column<string>(type: "TEXT", nullable: false),
                    Haslo = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    NrTelefonu = table.Column<string>(type: "TEXT", nullable: false),
                    Wojewodztwo = table.Column<int>(type: "INTEGER", nullable: false),
                    Miasto = table.Column<string>(type: "TEXT", nullable: false),
                    Ulica = table.Column<string>(type: "TEXT", nullable: false),
                    NrDomu = table.Column<string>(type: "TEXT", nullable: false),
                    NrMieszkania = table.Column<string>(type: "TEXT", nullable: false),
                    KodPocztowy = table.Column<string>(type: "TEXT", nullable: false),
                    CzyKlient = table.Column<bool>(type: "INTEGER", nullable: false),
                    CzyZarchiwizowany = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DbPracownik", x => x.IdPracownik);
                });

            migrationBuilder.CreateTable(
                name: "DbSeans",
                columns: table => new
                {
                    IdSeans = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Zdjecie = table.Column<byte[]>(type: "BLOB", nullable: true),
                    Tytul = table.Column<string>(type: "TEXT", nullable: false),
                    Opis = table.Column<string>(type: "TEXT", nullable: false),
                    Dlugosc = table.Column<string>(type: "TEXT", nullable: false),
                    Data = table.Column<string>(type: "TEXT", nullable: false),
                    ZajeteMiejsca = table.Column<string>(type: "TEXT", nullable: false),
                    CzyZarchiwizowany = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DbSeans", x => x.IdSeans);
                });

            migrationBuilder.CreateTable(
                name: "DbBilet",
                columns: table => new
                {
                    IdBilet = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Imie = table.Column<string>(type: "TEXT", nullable: false),
                    Nazwisko = table.Column<string>(type: "TEXT", nullable: false),
                    Cena = table.Column<double>(type: "REAL", nullable: false),
                    Siedzenie = table.Column<string>(type: "TEXT", nullable: false),
                    IdKlient = table.Column<int>(type: "INTEGER", nullable: false),
                    IdSeans = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DbBilet", x => x.IdBilet);
                    table.ForeignKey(
                        name: "FK_DbBilet_DbKlient_IdKlient",
                        column: x => x.IdKlient,
                        principalTable: "DbKlient",
                        principalColumn: "IdKlient",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DbBilet_DbSeans_IdSeans",
                        column: x => x.IdSeans,
                        principalTable: "DbSeans",
                        principalColumn: "IdSeans",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DbOpinia",
                columns: table => new
                {
                    IdOpinia = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Tytul = table.Column<string>(type: "TEXT", nullable: false),
                    Komentarz = table.Column<string>(type: "TEXT", nullable: false),
                    Data = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Ocena = table.Column<int>(type: "INTEGER", nullable: false),
                    CzyZarchiwizowany = table.Column<bool>(type: "INTEGER", nullable: false),
                    IdKlient1 = table.Column<int>(type: "INTEGER", nullable: false),
                    IdSeans1 = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DbOpinia", x => x.IdOpinia);
                    table.ForeignKey(
                        name: "FK_DbOpinia_DbKlient_IdKlient1",
                        column: x => x.IdKlient1,
                        principalTable: "DbKlient",
                        principalColumn: "IdKlient",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DbOpinia_DbSeans_IdSeans1",
                        column: x => x.IdSeans1,
                        principalTable: "DbSeans",
                        principalColumn: "IdSeans",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DbBilet_IdKlient",
                table: "DbBilet",
                column: "IdKlient");

            migrationBuilder.CreateIndex(
                name: "IX_DbBilet_IdSeans",
                table: "DbBilet",
                column: "IdSeans");

            migrationBuilder.CreateIndex(
                name: "IX_DbOpinia_IdKlient1",
                table: "DbOpinia",
                column: "IdKlient1");

            migrationBuilder.CreateIndex(
                name: "IX_DbOpinia_IdSeans1",
                table: "DbOpinia",
                column: "IdSeans1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DbBilet");

            migrationBuilder.DropTable(
                name: "DbOpinia");

            migrationBuilder.DropTable(
                name: "DbPracownik");

            migrationBuilder.DropTable(
                name: "DbKlient");

            migrationBuilder.DropTable(
                name: "DbSeans");
        }
    }
}
