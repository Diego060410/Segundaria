namespace Segundaria.DomainModels
{
    public class Section
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid GradeId { get; set; }

        public ICollection<Tuition> Tuitions { get; set; }
    }
}
