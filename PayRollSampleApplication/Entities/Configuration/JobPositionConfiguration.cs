using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using PayRollSampleApplication.Entities.Models;

namespace PayRollSampleApplication.Entities.Configuration
{
    public class JobPositionConfiguration : IEntityTypeConfiguration<JobPosition>
    {
        public void Configure(EntityTypeBuilder<JobPosition> entity)
        {
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.HasOne(d => d.Department)
                .WithMany(p => p.JobPositions)
                .HasForeignKey(d => d.DepartmentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Department_JobPosition");

            entity.HasData
            (
                new JobPosition
                {
                    Id = 1,
                    Name = "Project Manager",
                    DepartmentId = 1
                },
                new JobPosition
                {
                    Id = 2,
                    Name = "HR",
                    DepartmentId = 2
                },
                 new JobPosition
                 {
                     Id = 3,
                     Name = "Marketing Specialist",
                     DepartmentId = 3
                 },
                  new JobPosition
                  {
                      Id = 4,
                      Name = "Accountant",
                      DepartmentId = 4
                  },
                new JobPosition
                {
                    Id = 5,
                    Name = "Sales Man",
                    DepartmentId = 5
                },
                 new JobPosition
                 {
                     Id = 6,
                     Name = "Dot Net developer",
                     DepartmentId = 1
                 }
            );
        }
    }
}