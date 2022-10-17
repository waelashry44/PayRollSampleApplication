using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using PayRollSampleApplication.Entities.Models;

namespace PayRollSampleApplication.Entities.Configuration
{
    public class NationalityConfiguration : IEntityTypeConfiguration<Nationality>
    {
        public void Configure(EntityTypeBuilder<Nationality> entity)
        {
            entity.Property(e => e.Name).HasMaxLength(50);

            entity.HasData
            (
                new Nationality
                {
                    NationalityId = 1,
                    Name = "Saudi"
                },
                new Nationality
                {
                    NationalityId = 2,
                    Name = "Egyptian",
                },
                 new Nationality
                 {
                     NationalityId = 3,
                     Name = "Jordan"
                 }
            );
        }
    }
}