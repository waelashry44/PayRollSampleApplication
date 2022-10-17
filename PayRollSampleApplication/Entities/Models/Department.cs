using System.ComponentModel.DataAnnotations;

namespace PayRollSampleApplication.Entities.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public virtual ICollection<JobPosition>? JobPositions { get; set; }

    }
}
