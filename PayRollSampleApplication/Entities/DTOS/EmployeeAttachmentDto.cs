using PayRollSampleApplication.Entities.Models;
using System.Text.Json.Serialization;

namespace PayRollSampleApplication.Entities.DTOS
{
    public class EmployeeAttachmentDto
    {
        public DateTime? IssueDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string? FileType { get; set; }
        public string? FileName { get; set; }
        public string? FilePath { get; set; }
        public string File { get; set; } = null!;
    }
}
