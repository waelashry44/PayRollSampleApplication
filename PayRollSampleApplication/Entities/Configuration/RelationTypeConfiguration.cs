using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using PayRollSampleApplication.Entities.Models;

namespace PayRollSampleApplication.Entities.Configuration
{
    public class RelationTypeConfiguration : IEntityTypeConfiguration<RelationType>
    {
        public void Configure(EntityTypeBuilder<RelationType> entity)
        {
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.HasData
            (
                new RelationType
                {
                    Id = 1,
                    Name = "Wife"
                },
                new RelationType
                {
                    Id = 2,
                    Name = "Daughter",
                },
                 new RelationType
                 {
                     Id = 3,
                     Name = "Son"
                 }
            );
        }
    }
}