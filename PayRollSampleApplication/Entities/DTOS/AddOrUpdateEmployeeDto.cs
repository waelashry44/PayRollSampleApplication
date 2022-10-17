using PayRollSampleApplication.Entities.Models;
using System.ComponentModel.DataAnnotations;

namespace PayRollSampleApplication.Entities.DTOS
{
    public class AddOrUpdateEmployeeDto
    {
        public string IdentifierNumber { get; set; }
        public string FullName { get; set; }
        public string? HomeAddress { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime? JoinDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? JobStatusId { get; set; }
        public int? DepartmentId { get; set; }
        public int? JobPositionId { get; set; }
        public IEnumerable<EmployeeAttachmentDto> EmployeeAttachments { get; set; } = new List<EmployeeAttachmentDto>();
        public List<DependentDto> Dependents { get; set; } = new List<DependentDto>();
        public List<SalaryDetailDto> SalaryDetails { get; set; } = new List<SalaryDetailDto>();
    }
}
