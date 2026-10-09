using Microsoft.EntityFrameworkCore.Migrations;
using System.Net.NetworkInformation;

#nullable disable

namespace WebApplication2.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("insert into Brands (Name, Description, Status) values ('Apple', 'Mauris enim leo, rhoncus sed, vestibulum sit amet, cursus id, turpis.', 1);insert into Brands (Name, Description, Status) values ('oppo', 'Nulla tellus.', 1);insert into Brands (Name, Description, Status) values ('Realme', 'Nullam sit amet turpis elementum ligula vehicula consequat.', 0);insert into Brands (Name, Description, Status) values ('HP', 'Donec ut dolor.', 1);insert into Brands (Name, Description, Status) values ('Nokia', 'Praesent blandit.', 0);");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete from Brands");
        }
    }
}
