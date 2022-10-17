using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace PayRollSampleApplication.Entities.Configuration
{
    public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> entity)
        {
            entity.HasData(              
                new IdentityRole
                {
                    Name = "HrManager",
                    NormalizedName = "HRMANAGER"
                },
                 new IdentityRole
                 {
                     Name = "PayRollManager",
                     NormalizedName = "PAYROLLMANAGER"
                 }
            );
        }
    }
}
