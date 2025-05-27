namespace Segundaria.DataModels
{
    public class Degree
    {
        public Guid Id { get; set; }
        public Guid StudentId { get; set; }
        public Guid CourseId { get; set; }
        public Guid PeriodId { get; set; }
        public decimal FinalNote { get; set; }
        public string State { get; set; }
    }
}
