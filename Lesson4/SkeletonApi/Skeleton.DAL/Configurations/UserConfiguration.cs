using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Skeleton.DAL.Entities;

namespace Skeleton.DAL.Context;

public class UserConfiguration: IEntityTypeConfiguration<UserEntity>
{
    public void Configure(EntityTypeBuilder<UserEntity> builder)
    {
        builder.HasIndex(x => x.Id);
        builder.Property(x => x.Name);
        builder.Property(x => x.Surname);
        builder.Property(x => x.Password);

        builder
            .HasMany(x => x.Tests)
            .WithOne(x => x.User)
            .HasForeignKey(x => x.CreatedForUserId)
            .HasPrincipalKey(x => x.Id)
            .OnDelete(DeleteBehavior.ClientSetNull);
    }
}