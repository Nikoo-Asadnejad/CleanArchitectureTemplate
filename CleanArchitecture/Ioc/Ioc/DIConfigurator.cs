using Application.Repository.GenericRepository.Command;
using Application.Repository.GenericRepository.Query;
using Application.Repository.UnitOfWork;
using Infrastructure.AppEventBus;
using Infrastructure.Context;
using Infrastructure.Interceptors;
using Infrastructure.Repository.GenericRepository.Command;
using Infrastructure.Repository.GenericRepository.Query;
using Infrastructure.Repository.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Ioc.Ioc;

public static class DIConfigurator
{
    public static void InjectServices(IServiceCollection services , IConfiguration configuration)
    {
        services.AddMemoryCache();
        services.AddTransient<IUnitOfWork, UnitOfWork>();
        services.AddScoped<DbContext, CommandContext>();
        services.AddScoped<DbContext, QueryContext>();
        services.AddSingleton<InMemoryMessageQueue>();
        services.AddSingleton<IEventBus, EventBus>();
        services.AddSingleton<PublishDomainEventsInterceptor>();
        services.AddHostedService<IntegrationEventProcessor>();
        services.AddTransient(typeof(IRepository<>), typeof(Repository<>));
        services.AddTransient(typeof(IQueryGenericRepository<>), typeof(QueryGenericRepository<>));
       // services.Decorate(typeof(IQueryGenericRepository<>), typeof(CacheRepository<>));
    }
}