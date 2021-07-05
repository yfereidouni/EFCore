using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCore.Migrations
{
    public partial class init4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contact_tbl_People_PersonId",
                table: "Contact");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tbl_People",
                schema: "dbo",
                table: "tbl_People");

            migrationBuilder.RenameTable(
                name: "tbl_People",
                schema: "dbo",
                newName: "People",
                newSchema: "dbo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_People",
                schema: "dbo",
                table: "People",
                column: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contact_People_PersonId",
                table: "Contact",
                column: "PersonId",
                principalSchema: "dbo",
                principalTable: "People",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contact_People_PersonId",
                table: "Contact");

            migrationBuilder.DropPrimaryKey(
                name: "PK_People",
                schema: "dbo",
                table: "People");

            migrationBuilder.RenameTable(
                name: "People",
                schema: "dbo",
                newName: "tbl_People",
                newSchema: "dbo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tbl_People",
                schema: "dbo",
                table: "tbl_People",
                column: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contact_tbl_People_PersonId",
                table: "Contact",
                column: "PersonId",
                principalSchema: "dbo",
                principalTable: "tbl_People",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
