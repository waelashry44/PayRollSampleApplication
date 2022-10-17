
namespace PayRollSampleApplication.Entities.Models
{
    public class Dependent
    {
        public int DependentId { get; set; }
        public string IdentifierNumber { get; set; } = null!;
        public string FullName { get; set; } = null!;
        public DateTime BirthDate { get; set; }
        public int RelationTypeId { get; set; }
        public RelationType? RelationType { get; set; }
        public int NationalityId { get; set; }
        public virtual Nationality? Nationality { get; set; }
        public int EmployeeId { get; set; }
        public virtual Employee? Employee { get; set; }
    }
}
