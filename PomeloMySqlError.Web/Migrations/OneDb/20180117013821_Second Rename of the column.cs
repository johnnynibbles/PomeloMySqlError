using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace PomeloMySqlError.Web.Migrations.OneDb
{
    public partial class SecondRenameofthecolumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "position_name",
                table: "board_positions",
                newName: "the_name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "the_name",
                table: "board_positions",
                newName: "position_name");
        }
    }
}
