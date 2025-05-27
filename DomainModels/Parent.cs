namespace Segundaria.DomainModels
{
    public class Parent
    {
        public Guid Id { get; set; }
        public string Names { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Relationship { get; set; }

        public Guid StudentId { get; set; }
        public Student Student { get; set; }
    }
}
