using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalSystem.Migrations
{
    /// <inheritdoc />
    public partial class adddoctor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("insert into Doctor ( Name, image,specializationId) values ( 'Cassondra Theodoris', '1.png', 1);insert into Doctor ( Name, image,specializationId) values ('Amanda Camidge', '5.png', 2);insert into Doctor ( Name, image,specializationId) values ( 'Reginauld Wysome', '8.png', 3);insert into Doctor ( Name, image,specializationId) values ( 'Sari Swanborough', '3.png', 1);insert into Doctor ( Name, image,specializationId) values ( 'Yetty Tollfee', '6.png', 2);insert into Doctor ( Name, image,specializationId) values ( 'Lil Hawarden', '7.png', 3);insert into Doctor ( Name, image,specializationId) values ( 'Sashenka Hutchin', '2.png', 1);insert into Doctor ( Name, image,specializationId) values ( 'Elliot Weller', '4.png', 2);");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("delete from Doctor;");
        }
    }
}
