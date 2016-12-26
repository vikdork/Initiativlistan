using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Initiativlistan.Data.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Priolista",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    akut = table.Column<bool>(nullable: false),
                    beroende = table.Column<string>(nullable: true),
                    beskrivAkut = table.Column<string>(nullable: true),
                    beskrivning = table.Column<string>(nullable: true),
                    beställare = table.Column<string>(nullable: true),
                    budget = table.Column<string>(nullable: true),
                    finnsIPlan = table.Column<string>(nullable: true),
                    framtidaPåverkan = table.Column<string>(nullable: true),
                    förvaltning = table.Column<string>(nullable: true),
                    kategorisering = table.Column<string>(nullable: true),
                    kostnader = table.Column<string>(nullable: true),
                    namnPåAktvivitet = table.Column<string>(nullable: true),
                    nuvarandePåverkan = table.Column<string>(nullable: true),
                    tidasram = table.Column<DateTime>(nullable: false),
                    typAvFörändring = table.Column<string>(nullable: true),
                    verksamhetspåverkarn = table.Column<string>(nullable: true),
                    ärendeägare = table.Column<string>(nullable: true),
                    önskatDatum = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Priolista", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Priolista");
        }
    }
}
