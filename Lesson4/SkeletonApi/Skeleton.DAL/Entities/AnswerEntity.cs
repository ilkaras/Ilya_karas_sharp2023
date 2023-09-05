namespace Skeleton.DAL.Entities;

public class AnswerEntity : BaseEntity
{
    public string Text { get; set; } = default!;
    public bool IsCorrect { get; set; } = default!;
    public Guid QuestionId { get; set; } = default!;
    public virtual QuestionEntity? Question { get; set; }
}