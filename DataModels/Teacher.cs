namespace Segundaria.DataModels
{
    public class Teacher
    {
        public Guid Id { get; set; }
        public string Names { get; set; }
        public string LastName { get; set; }
        public string Specialty { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}
