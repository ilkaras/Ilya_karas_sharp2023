namespace Skeleton.DAL.Entities;

public class QuestionEntity : BaseEntity
{
    public string Text { get; set; } = default!;
    public Guid TestId { get; set; } = default!;
    public virtual ICollection<AnswerEntity>? Answers { get; set; }
    public virtual TestEntity? Test { get; set; }
}