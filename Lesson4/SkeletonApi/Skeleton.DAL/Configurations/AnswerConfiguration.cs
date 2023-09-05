using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Skeleton.DAL.Entities;

namespace Skeleton.DAL.Context;

public class AnswerConfiguration : IEntityTypeConfiguration<AnswerEntity>
{
    public void Configure(EntityTypeBuilder<AnswerEntity> builder)
    {
        builder.HasIndex(x => x.Id);
        builder.Property(x => x.Text);
        builder.Property(x => x.IsCorrect);
        builder.Property(x => x.QuestionId);
    }
}