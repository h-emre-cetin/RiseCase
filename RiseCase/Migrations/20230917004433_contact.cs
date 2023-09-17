using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RiseCase.Migrations
{
    public partial class contact : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Company = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ContactsInfos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ContactId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ContactType = table.Column<int>(type: "int", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactModelId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactsInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContactsInfos_Contacts_ContactModelId",
                        column: x => x.ContactModelId,
                        principalTable: "Contacts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ContactsInfos_ContactModelId",
                table: "ContactsInfos",
                column: "ContactModelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContactsInfos");

            migrationBuilder.DropTable(
                name: "Contacts");
        }
    }
}
