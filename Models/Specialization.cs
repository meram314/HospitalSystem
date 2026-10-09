namespace HospitalSystem.Models
{
    public class Specialization
    {
        public int SpecializationId { get; set; }
        public string Name { get; set; }
        public ICollection<Doctor> Doctor { get; set; }
    }
}
