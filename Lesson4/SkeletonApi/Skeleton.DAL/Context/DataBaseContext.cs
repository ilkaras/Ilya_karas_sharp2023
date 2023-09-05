using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Skeleton.DAL.Entities;

namespace Skeleton.DAL.Context;

public class DataBaseContext : DbContext
{
    public virtual DbSet<UserEntity> Users { get; set; }
    public virtual DbSet<TestEntity> Tests { get; set; }
    public virtual DbSet<QuestionEntity> Questions { get; set; }
    public virtual DbSet<AnswerEntity> Answers { get; set; }
    
    private readonly IConfiguration _configuration;
    
    public DataBaseContext(DbContextOptions<DataBaseContext> options, IConfiguration configuration ) : base(options)
    {
        _configuration = configuration;
    }
    
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfiguration(new UserConfiguration());
        builder.ApplyConfiguration(new TestConfiguration());
        builder.ApplyConfiguration(new QuestionConfiguration());
        builder.ApplyConfiguration(new AnswerConfiguration());

        base.OnModelCreating(builder);
    }
}