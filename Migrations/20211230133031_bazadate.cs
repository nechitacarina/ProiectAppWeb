using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Nechita_Carina_Proiect.Migrations
{
    public partial class bazadate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TipCard",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descriere = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipCard", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TipClient",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descriere = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipClient", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TipContBancar",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descriere = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipContBancar", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TipImprumut",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descriere = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipImprumut", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TipTranzactie",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descriere = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipTranzactie", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nume = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    prenume = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    data_nasterii = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ocupatie = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    telefon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    data_inscrierii = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TipClientID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Client_TipClient_TipClientID",
                        column: x => x.TipClientID,
                        principalTable: "TipClient",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cont",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sold = table.Column<decimal>(type: "decimal(6,2)", nullable: false),
                    data_deschiderii = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ClientID = table.Column<int>(type: "int", nullable: false),
                    TipContBancarID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cont", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Cont_Client_ClientID",
                        column: x => x.ClientID,
                        principalTable: "Client",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cont_TipContBancar_TipContBancarID",
                        column: x => x.TipContBancarID,
                        principalTable: "TipContBancar",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Card",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PIN = table.Column<int>(type: "int", nullable: false),
                    TipCardID = table.Column<int>(type: "int", nullable: false),
                    ContID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Card", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Card_Cont_ContID",
                        column: x => x.ContID,
                        principalTable: "Cont",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Card_TipCard_TipCardID",
                        column: x => x.TipCardID,
                        principalTable: "TipCard",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Imprumut",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    data_inceput = table.Column<DateTime>(type: "datetime2", nullable: false),
                    data_final = table.Column<DateTime>(type: "datetime2", nullable: false),
                    durata = table.Column<int>(type: "int", nullable: false),
                    suma_imprumutata = table.Column<double>(type: "float", nullable: false),
                    suma_datorata = table.Column<double>(type: "float", nullable: false),
                    ContID = table.Column<int>(type: "int", nullable: false),
                    TipImprumutID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Imprumut", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Imprumut_Cont_ContID",
                        column: x => x.ContID,
                        principalTable: "Cont",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Imprumut_TipImprumut_TipImprumutID",
                        column: x => x.TipImprumutID,
                        principalTable: "TipImprumut",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tranzactie",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    data_tranzactie = table.Column<DateTime>(type: "datetime2", nullable: false),
                    suma = table.Column<decimal>(type: "decimal(6,2)", nullable: false),
                    TipTranzactieID = table.Column<int>(type: "int", nullable: false),
                    ContID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tranzactie", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Tranzactie_Cont_ContID",
                        column: x => x.ContID,
                        principalTable: "Cont",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tranzactie_TipTranzactie_TipTranzactieID",
                        column: x => x.TipTranzactieID,
                        principalTable: "TipTranzactie",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Card_ContID",
                table: "Card",
                column: "ContID");

            migrationBuilder.CreateIndex(
                name: "IX_Card_TipCardID",
                table: "Card",
                column: "TipCardID");

            migrationBuilder.CreateIndex(
                name: "IX_Client_TipClientID",
                table: "Client",
                column: "TipClientID");

            migrationBuilder.CreateIndex(
                name: "IX_Cont_ClientID",
                table: "Cont",
                column: "ClientID");

            migrationBuilder.CreateIndex(
                name: "IX_Cont_TipContBancarID",
                table: "Cont",
                column: "TipContBancarID");

            migrationBuilder.CreateIndex(
                name: "IX_Imprumut_ContID",
                table: "Imprumut",
                column: "ContID");

            migrationBuilder.CreateIndex(
                name: "IX_Imprumut_TipImprumutID",
                table: "Imprumut",
                column: "TipImprumutID");

            migrationBuilder.CreateIndex(
                name: "IX_Tranzactie_ContID",
                table: "Tranzactie",
                column: "ContID");

            migrationBuilder.CreateIndex(
                name: "IX_Tranzactie_TipTranzactieID",
                table: "Tranzactie",
                column: "TipTranzactieID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Card");

            migrationBuilder.DropTable(
                name: "Imprumut");

            migrationBuilder.DropTable(
                name: "Tranzactie");

            migrationBuilder.DropTable(
                name: "TipCard");

            migrationBuilder.DropTable(
                name: "TipImprumut");

            migrationBuilder.DropTable(
                name: "Cont");

            migrationBuilder.DropTable(
                name: "TipTranzactie");

            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.DropTable(
                name: "TipContBancar");

            migrationBuilder.DropTable(
                name: "TipClient");
        }
    }
}
