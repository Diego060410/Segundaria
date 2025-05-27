namespace Segundaria.DataModels
{
    public class Tuition
    {
        public Guid Id { get; set; }
        public Guid StudentId { get; set; }
        public Guid SectionId { get; set; }
        public Guid PeriodId { get; set; }
        public DateTime DateTuition { get; set; }
        public string State { get; set; }
    }
}
