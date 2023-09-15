using Dal.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Skeleton.DAL.Interfaces;

namespace Dal.Extensions;

public static class ServiceCollectionExtension
{
    public static void InjectDatabaseServices(this IServiceCollection services)
    {
        services.AddDatabase();
    }

    private static void AddDatabase(this IServiceCollection services)
    {
    }

    public static void AddRepositories(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<IUserRepository, UserRepository>();
        serviceCollection.AddScoped<ITestRepository, TestRepository>();
        serviceCollection.AddScoped<IAnswerRepository, AnswerRepository>();
        serviceCollection.AddScoped<IQuestionRepository, QuestionRepository>();
    }
}