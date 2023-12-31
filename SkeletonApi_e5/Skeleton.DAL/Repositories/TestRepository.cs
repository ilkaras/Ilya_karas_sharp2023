﻿using Microsoft.EntityFrameworkCore;
using Skeleton.DAL.Entities;
using Skeleton.DAL.Interfaces;

namespace Dal.Repositories;

public class TestRepository : BaseRepository<Test>, ITestRepository
{
    public TestRepository(AppDbContext dbContext) : base(dbContext)
    {
    }

    public async Task<IEnumerable<Test>> GetTestsByUserIdAsync(Guid userId)
    {
        return await _dbContext.Set<Test>().Where(x => x.CreatedForUserId == userId).ToListAsync();
    }

    public async Task<Test> GetByIdWithQuestionsAsync(Guid id)
    {
        var entity = await _dbContext.Set<Test>().
            Include(x => x.Questions).
            FirstOrDefaultAsync(x => x.Id == id);
        
        return entity;
    }

    public async Task<string?> GetDescriptionAsync(Guid id)
    {
        var entity = await GetByIdAsync(id);
        return entity.Description;
    }
}