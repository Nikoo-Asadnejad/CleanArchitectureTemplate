namespace Infrastructure.Interfaces;

public interface IUnitOfWork
{
    Task SaveAsync();
    Task DisposeAsync();
}