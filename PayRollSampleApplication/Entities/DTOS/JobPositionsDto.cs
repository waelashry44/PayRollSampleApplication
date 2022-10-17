namespace PayRollSampleApplication.Entities.DTOS
{
    public class JobPositionsDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int DepartmentId { get; set; }
    }
}
