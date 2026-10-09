using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication2.Migrations
{
    /// <inheritdoc />
    public partial class addtocategories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("insert into Categories (Name, Description, Status) values ('Tvs', 'Aenean lectus.', 0);insert into Categories (Name, Description, Status) values ('Tvs', 'Morbi non lectus.', 1);insert into Categories (Name, Description, Status) values ('Cameras', 'Curabitur gravida nisi at nibh.', 1);insert into Categories (Name, Description, Status) values ('Mobiles', 'Cras in purus eu magna vulputate luctus.', 1);insert into Categories (Name, Description, Status) values ('Tablets', 'Pellentesque viverra pede ac diam.', 1);");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete from Categories");
        }
    }
}
