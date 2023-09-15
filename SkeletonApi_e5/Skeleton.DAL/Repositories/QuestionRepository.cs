using Skeleton.DAL.Entities;
using Skeleton.DAL.Interfaces;

namespace Dal.Repositories;

public class QuestionRepository : BaseRepository<Question>, IQuestionRepository
{
    public QuestionRepository(AppDbContext dbContext) : base(dbContext)
    {
    }
}