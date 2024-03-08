namespace Infrastructure.AppEventBus;

public interface IEventBus
{
    Task PublishAsync<T>(T integrationEvent) where T : IIntegrationEvent;
}