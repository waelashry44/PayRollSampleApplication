using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;

namespace PayRollSampleApplication.Entities.Models
{
    public class EmployeeAttachment
    {
        [Key]
        public int DocumentNo { get; set; }
        public int EmployeeId { get; set; }
        public DateTime? IssueDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string FilePath { get; set; } = null!;
        public virtual Employee? Employee { get; set; }
    }
}