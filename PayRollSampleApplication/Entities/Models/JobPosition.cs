namespace PayRollSampleApplication.Entities.Models
{
    public class JobPosition
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int DepartmentId { get; set; }
        public virtual Department? Department { get; set; }
    }
}
