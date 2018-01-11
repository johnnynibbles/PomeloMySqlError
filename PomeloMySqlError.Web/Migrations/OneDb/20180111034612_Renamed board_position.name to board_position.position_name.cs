using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace PomeloMySqlError.Web.Migrations.OneDb
{
    public partial class Renamedboard_positionnametoboard_positionposition_name : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "name",
                table: "board_positions",
                newName: "position_name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "position_name",
                table: "board_positions",
                newName: "name");
        }
    }
}
