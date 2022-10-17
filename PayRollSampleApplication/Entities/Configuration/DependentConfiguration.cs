using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PayRollSampleApplication.Entities.Models;

namespace PayRollSampleApplication.Entities.Configuration
{
    public class DependentConfiguration : IEntityTypeConfiguration<Dependent>
    {
        public void Configure(EntityTypeBuilder<Dependent> entity)
        {
            entity.HasKey(e => e.DependentId);
            entity.Property(e => e.IdentifierNumber).HasMaxLength(10);
            entity.HasIndex(e => e.IdentifierNumber, "UQDependent_IdentifierNumber")
            .IsUnique();
            entity.Property(e => e.FullName).HasMaxLength(50);


            entity.HasOne(d => d.Employee)
                .WithMany(p => p.Dependents)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Employee_Dependents");
        }
    }
}
