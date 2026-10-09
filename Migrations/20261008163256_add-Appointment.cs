using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalSystem.Migrations
{
    /// <inheritdoc />
    public partial class addAppointment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("insert into Appointment (DoctorId, PatientName, AppointmentDate) values (17, 'Tabbie Pinilla', '2/21/2026');insert into Appointment (DoctorId, PatientName, AppointmentDate) values (18, 'Inez Husband', '6/12/2026');insert into Appointment (DoctorId, PatientName, AppointmentDate) values (19, 'Yolanda Ezzell', '7/23/2026');insert into Appointment (DoctorId, PatientName, AppointmentDate) values (20, 'Tamas Orrell', '1/8/2026');insert into Appointment (DoctorId, PatientName, AppointmentDate) values (21, 'Burtie Relton', '5/26/2026');insert into Appointment (DoctorId, PatientName, AppointmentDate) values (22, 'Charmion Breed', '4/10/2026');insert into Appointment (DoctorId, PatientName, AppointmentDate) values (23, 'Jasper Growcock', '5/10/2026');insert into Appointment (DoctorId, PatientName, AppointmentDate) values (24, 'Juana McFarland', '4/19/2026');");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
