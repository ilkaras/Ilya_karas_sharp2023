using Microsoft.EntityFrameworkCore;
using Skeleton.DAL.Entities;
using Skeleton.DAL.Interfaces;

namespace Dal.Repositories;

public class UserRepository : BaseRepository<User>, IUserRepository
{
    public UserRepository(AppDbContext dbContext) : base(dbContext)
    {
    }

    public async Task<User?> GetUserByCredentialsAsync(string name, string password)
    {
        return await _dbContext.Set<User>().
            FirstOrDefaultAsync(x => x.Name == name && x.Password == password);
    }
}