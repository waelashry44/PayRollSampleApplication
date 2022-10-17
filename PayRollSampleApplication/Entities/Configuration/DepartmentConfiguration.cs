using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using PayRollSampleApplication.Entities.Models;

namespace PayRollSampleApplication.Entities.Configuration
{
    public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> entity)
        {
            entity.Property(e => e.Name).HasMaxLength(50);

            entity.HasData
            (
                new Department
                {
                    Id = 1,
                    Name = "Information Technology"
                },
                new Department
                {
                    Id = 2,
                    Name = "Human Resource",
                },
                 new Department
                 {
                     Id = 3,
                     Name = "Marketing"
                 },
                 new Department
                 {
                     Id = 4,
                     Name = "Finance"
                 },
                 new Department
                 {
                     Id = 5,
                     Name = "Sales"
                 }
            );
        }
    }
}