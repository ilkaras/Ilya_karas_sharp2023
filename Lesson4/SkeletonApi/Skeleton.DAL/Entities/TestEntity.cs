namespace Skeleton.DAL.Entities;

public class TestEntity : BaseEntity
{
    public string Title { get; set; } = default!;
    public string Description { get; set; } = default!;
    public Guid CreatedForUserId { get; set; } = default!;
    public virtual ICollection<QuestionEntity>? Questions { get; set; }
    public virtual UserEntity? User { get; set; }
}