using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using PayRollSampleApplication.Entities.Models;

namespace PayRollSampleApplication.Entities.Configuration
{
    public class JobStatusConfiguration : IEntityTypeConfiguration<JobStatus>
    {
        public void Configure(EntityTypeBuilder<JobStatus> entity)
        {
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.HasData
            (
                new JobStatus
                {
                    Id = 1,
                    Name = "Started"
                },
                new JobStatus
                {
                    Id = 2,
                    Name = "Not Yet Started",
                },
                 new JobStatus
                 {
                     Id = 3,
                     Name = "Not Working"
                 }
            );
        }
    }
}