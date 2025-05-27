namespace Segundaria.DataModels
{
    public class Course
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Credits { get; set; }
        public string GradeLevel { get; set; }
        public bool Active { get; set; }

        public ICollection<Degree> Degree { get; set; }
    }
}
