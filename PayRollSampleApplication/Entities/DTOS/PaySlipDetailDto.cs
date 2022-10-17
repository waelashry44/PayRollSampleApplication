namespace PayRollSampleApplication.Entities.DTOS
{
    public class PaySlipDetailDto
    {
        public int EmployeeId { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
