using PayRollSampleApplication.Entities.Models;

namespace PayRollSampleApplication.Entities.DTOS
{
    public class DependentDto
    {
        public string IdentifierNumber { get; set; } = null!;
        public string FullName { get; set; } = null!;
        public DateTime BirthDate { get; set; }
        public int RelationTypeId { get; set; }
        public int NationalityId { get; set; }
    }
}
