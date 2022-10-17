using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PayRollSampleApplication.Entities.Models;
using System.Reflection.Emit;

namespace PayRollSampleApplication.Entities.Configuration
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> entity)
        {
            entity.HasKey(e => e.EmployeeId);
            entity.Property(e => e.IdentifierNumber).HasMaxLength(10);
            entity.HasIndex(e => e.IdentifierNumber, "UQ_IdentifierNumber")
            .IsUnique();
            entity.Property(e => e.FullName).HasMaxLength(50);
            entity.Property(e => e.HomeAddress).HasMaxLength(100);

        }
    }
}
