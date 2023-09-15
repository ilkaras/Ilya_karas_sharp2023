using Skeleton.DAL.Entities;
using Skeleton.DAL.Interfaces;

namespace Dal.Repositories.Interfaces;

public interface IAnswerRepository : IBaseRepository<Answer>
{
    Task<bool> CheckIsCorrectAsync(Guid id);
    Task<IEnumerable<Answer>> GetAllByQuestionIdAsync(Guid questionId);
}