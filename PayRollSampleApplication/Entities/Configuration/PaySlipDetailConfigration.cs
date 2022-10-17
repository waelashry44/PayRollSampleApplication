using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using PayRollSampleApplication.Entities.Models;

namespace PayRollSampleApplication.Entities.Configuration
{
    public class PaySlipDetailConfigration : IEntityTypeConfiguration<PaySlipDetail>
    {
        public void Configure(EntityTypeBuilder<PaySlipDetail> entity)
        {
            entity.HasKey(e => e.Id);
            
            entity.HasOne(d => d.Employee)
           .WithMany(p => p.PaySlipDetails)
           .HasForeignKey(d => d.EmployeeId)
           .OnDelete(DeleteBehavior.Cascade)
           .HasConstraintName("FK_PaySlipDetail_Employee");
        }
    }
}
