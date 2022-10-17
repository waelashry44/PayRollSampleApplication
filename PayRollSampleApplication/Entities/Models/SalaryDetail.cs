namespace PayRollSampleApplication.Entities.Models
{
    public class SalaryDetail
    {
        public int SalaryDetailId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public decimal BasicSalary { get; set; }
        public decimal Housing { get; set; }
        public decimal Transport { get; set; }
        public virtual Employee? Employee { get; set; }
    }
}
