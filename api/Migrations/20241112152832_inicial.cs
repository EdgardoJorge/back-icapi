using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "generoMusical",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    nombre_genero = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_generoMusical", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "pais",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    nombre_pais = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pais", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "banda",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    nombre_banda = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    id_genero = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_banda", x => x.id);
                    table.ForeignKey(
                        name: "FK_banda_generoMusical_id_genero",
                        column: x => x.id_genero,
                        principalTable: "generoMusical",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "album",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    nombre_Album = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    id_banda = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_album", x => x.Id);
                    table.ForeignKey(
                        name: "FK_album_banda_id_banda",
                        column: x => x.id_banda,
                        principalTable: "banda",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "artista",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    apellidos = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    nombres = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    fecha_Nacimiento = table.Column<DateTime>(type: "TEXT", nullable: false),
                    vivo = table.Column<int>(type: "INTEGER", nullable: false),
                    id_pais = table.Column<int>(type: "INTEGER", nullable: false),
                    id_banda = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_artista", x => x.id);
                    table.ForeignKey(
                        name: "FK_artista_banda_id_banda",
                        column: x => x.id_banda,
                        principalTable: "banda",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_artista_pais_id_pais",
                        column: x => x.id_pais,
                        principalTable: "pais",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "cancion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    nombre_Cancion = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    id_album = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cancion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_cancion_album_id_album",
                        column: x => x.id_album,
                        principalTable: "album",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_album_id_banda",
                table: "album",
                column: "id_banda");

            migrationBuilder.CreateIndex(
                name: "IX_artista_id_banda",
                table: "artista",
                column: "id_banda");

            migrationBuilder.CreateIndex(
                name: "IX_artista_id_pais",
                table: "artista",
                column: "id_pais");

            migrationBuilder.CreateIndex(
                name: "IX_banda_id_genero",
                table: "banda",
                column: "id_genero");

            migrationBuilder.CreateIndex(
                name: "IX_cancion_id_album",
                table: "cancion",
                column: "id_album");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "artista");

            migrationBuilder.DropTable(
                name: "cancion");

            migrationBuilder.DropTable(
                name: "pais");

            migrationBuilder.DropTable(
                name: "album");

            migrationBuilder.DropTable(
                name: "banda");

            migrationBuilder.DropTable(
                name: "generoMusical");
        }
    }
}
