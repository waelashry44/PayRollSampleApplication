namespace PayRollSampleApplication.Entities.DTOS
{
    public class SalaryDetailDto
    {
        public DateTime? EffectiveDate { get; set; }
        public decimal BasicSalary { get; set; }
        public decimal Housing { get; set; }
        public decimal Transport { get; set; }
    }
}
