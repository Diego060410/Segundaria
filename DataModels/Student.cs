namespace Segundaria.DataModels
{
    public class Student
    {
        public Guid Id { get; set; }
        public string DNI { get; set; }
        public string Names { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string BloodLevel { get; set; }
        public string State { get; set; }

        public ICollection<Parent> Parents { get; set; }
        public ICollection<Degree> Degrees { get; set; }
        public ICollection<Tuition> Tuitions { get; set; }
    }
}
