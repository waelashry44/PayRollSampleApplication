namespace PayRollSampleApplication.Entities.DTOS
{
    public class EmployeePaySlipDetails
    {
        public int EmployeeId { get; set; }
        public List<AllPaySlipDto>? AllPaySlips { get; set; }

        public List<SalaryDetailDto>? SalaryDetails { get; set; }
    }
}
