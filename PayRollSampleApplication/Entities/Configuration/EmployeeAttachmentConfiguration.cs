using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PayRollSampleApplication.Entities.Models;

namespace PayRollSampleApplication.Entities.Configuration
{
    public class EmployeeAttachmentConfiguration : IEntityTypeConfiguration<EmployeeAttachment>
    {
        public void Configure(EntityTypeBuilder<EmployeeAttachment> entity)
        {
            entity.HasKey(e => e.DocumentNo);
            //entity.Property(e => e.FileName).HasMaxLength(30);
            //entity.Property(e => e.FileType).HasMaxLength(5);

            entity.HasOne(d => d.Employee)
                .WithMany(p => p.EmployeeAttachments)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Employee_EmployeeAttachments");


        }
    }
}
