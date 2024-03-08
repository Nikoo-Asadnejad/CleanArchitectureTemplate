using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.EntitytypeConfigurations;

public class ChangeLogConfiguration : IEntityTypeConfiguration<ChangeHistory>
{
    public void Configure(EntityTypeBuilder<ChangeHistory> builder)
    {
        builder.HasKey(b => b.Id);
        builder.Property(b => b.RelatedEntityType)
               .HasMaxLength(150);
    }
}

