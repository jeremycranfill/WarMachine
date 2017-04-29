using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WarMachine.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Units",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ARM = table.Column<int>(nullable: false),
                    CMD = table.Column<int>(nullable: false),
                    DEF = table.Column<int>(nullable: false),
                    FA = table.Column<int>(nullable: false),
                    MAT = table.Column<int>(nullable: false),
                    MaxUnit = table.Column<int>(nullable: false),
                    MinUnit = table.Column<int>(nullable: false),
                    PointCost = table.Column<int>(nullable: false),
                    RAT = table.Column<int>(nullable: false),
                    SPD = table.Column<int>(nullable: false),
                    STR = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Units", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Abilities",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    UnitModelID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abilities", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Abilities_Units_UnitModelID",
                        column: x => x.UnitModelID,
                        principalTable: "Units",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Spells",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AOE = table.Column<int>(nullable: false),
                    Cost = table.Column<int>(nullable: false),
                    Duration = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    OFF = table.Column<bool>(nullable: false),
                    POW = table.Column<int>(nullable: false),
                    RNG = table.Column<string>(nullable: true),
                    UnitModelID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spells", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Spells_Units_UnitModelID",
                        column: x => x.UnitModelID,
                        principalTable: "Units",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Weapons",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    POW = table.Column<int>(nullable: false),
                    RNG = table.Column<int>(nullable: false),
                    Type = table.Column<string>(nullable: true),
                    UnitModelID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weapons", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Weapons_Units_UnitModelID",
                        column: x => x.UnitModelID,
                        principalTable: "Units",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Abilities_UnitModelID",
                table: "Abilities",
                column: "UnitModelID");

            migrationBuilder.CreateIndex(
                name: "IX_Spells_UnitModelID",
                table: "Spells",
                column: "UnitModelID");

            migrationBuilder.CreateIndex(
                name: "IX_Weapons_UnitModelID",
                table: "Weapons",
                column: "UnitModelID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Abilities");

            migrationBuilder.DropTable(
                name: "Spells");

            migrationBuilder.DropTable(
                name: "Weapons");

            migrationBuilder.DropTable(
                name: "Units");
        }
    }
}
