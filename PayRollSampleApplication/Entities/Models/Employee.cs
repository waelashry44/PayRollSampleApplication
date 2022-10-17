using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PayRollSampleApplication.Entities.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string IdentifierNumber { get; set; } = null!;
        public string FullName { get; set; } = null!;
        public string? HomeAddress { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime? JoinDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int JobStatusId { get; set; }
        public JobStatus? JobStatus { get; set; }
        public int DepartmentId { get; set; }
        public virtual Department? Department { get; set; }
        public int JobPositionId { get; set; }
        public virtual JobPosition? JobPosition { get; set; }
        public virtual ICollection<PaySlipDetail>? PaySlipDetails { get; set; }
        public virtual ICollection<EmployeeAttachment>? EmployeeAttachments { get; set; }
        public virtual ICollection<Dependent>? Dependents { get; set; }
        public virtual ICollection<SalaryDetail>? SalaryDetails { get; set; }

    }
}
