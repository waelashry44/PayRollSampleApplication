using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PayRollSampleApplication.Entities.Models;

namespace PayRollSampleApplication.Entities.Configuration
{
    public class SalaryDetailConfiguration : IEntityTypeConfiguration<SalaryDetail>
    {
        public void Configure(EntityTypeBuilder<SalaryDetail> entity)
        {
            entity.HasKey(e => e.SalaryDetailId);

            entity.HasOne(d => d.Employee)
                .WithMany(p => p.SalaryDetails)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Employee_SalaryDetails");


        }
    }
}
