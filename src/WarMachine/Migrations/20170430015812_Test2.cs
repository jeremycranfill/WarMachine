using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WarMachine.Migrations
{
    public partial class Test2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Solos",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ARM = table.Column<int>(nullable: false),
                    CMD = table.Column<int>(nullable: false),
                    DEF = table.Column<int>(nullable: false),
                    FA = table.Column<int>(nullable: false),
                    MAT = table.Column<int>(nullable: false),
                    PointCost = table.Column<int>(nullable: false),
                    RAT = table.Column<int>(nullable: false),
                    SPD = table.Column<int>(nullable: false),
                    STR = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Solos", x => x.ID);
                });

            migrationBuilder.AddColumn<int>(
                name: "SoloModelID",
                table: "Weapons",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Spells",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SoloModelID",
                table: "Spells",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SoloModelID",
                table: "Abilities",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Weapons_SoloModelID",
                table: "Weapons",
                column: "SoloModelID");

            migrationBuilder.CreateIndex(
                name: "IX_Spells_SoloModelID",
                table: "Spells",
                column: "SoloModelID");

            migrationBuilder.CreateIndex(
                name: "IX_Abilities_SoloModelID",
                table: "Abilities",
                column: "SoloModelID");

            migrationBuilder.AddForeignKey(
                name: "FK_Abilities_Solos_SoloModelID",
                table: "Abilities",
                column: "SoloModelID",
                principalTable: "Solos",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Spells_Solos_SoloModelID",
                table: "Spells",
                column: "SoloModelID",
                principalTable: "Solos",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Weapons_Solos_SoloModelID",
                table: "Weapons",
                column: "SoloModelID",
                principalTable: "Solos",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Abilities_Solos_SoloModelID",
                table: "Abilities");

            migrationBuilder.DropForeignKey(
                name: "FK_Spells_Solos_SoloModelID",
                table: "Spells");

            migrationBuilder.DropForeignKey(
                name: "FK_Weapons_Solos_SoloModelID",
                table: "Weapons");

            migrationBuilder.DropIndex(
                name: "IX_Weapons_SoloModelID",
                table: "Weapons");

            migrationBuilder.DropIndex(
                name: "IX_Spells_SoloModelID",
                table: "Spells");

            migrationBuilder.DropIndex(
                name: "IX_Abilities_SoloModelID",
                table: "Abilities");

            migrationBuilder.DropColumn(
                name: "SoloModelID",
                table: "Weapons");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Spells");

            migrationBuilder.DropColumn(
                name: "SoloModelID",
                table: "Spells");

            migrationBuilder.DropColumn(
                name: "SoloModelID",
                table: "Abilities");

            migrationBuilder.DropTable(
                name: "Solos");
        }
    }
}
