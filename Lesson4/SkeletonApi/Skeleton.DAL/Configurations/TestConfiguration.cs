using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Skeleton.DAL.Entities;

namespace Skeleton.DAL.Context;

public class TestConfiguration : IEntityTypeConfiguration<TestEntity>
{
    public void Configure(EntityTypeBuilder<TestEntity> builder)
    {
        builder.HasIndex(x => x.Id);
        builder.Property(x => x.Title);
        builder.Property(x => x.Description);
        builder.Property(x => x.CreatedForUserId);

        builder
            .HasMany(x => x.Questions)
            .WithOne(x => x.Test)
            .HasForeignKey(x => x.TestId)
            .HasPrincipalKey(x => x.Id)
            .OnDelete(DeleteBehavior.ClientSetNull);
    }
}