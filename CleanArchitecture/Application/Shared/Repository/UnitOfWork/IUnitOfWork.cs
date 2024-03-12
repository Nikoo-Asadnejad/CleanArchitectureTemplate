using Microsoft.EntityFrameworkCore.Storage;

namespace Application.Repository.UnitOfWork;

public interface IUnitOfWork 
{ 
    Task<int> SaveAsync();
    int Save();
    Task DisposeAsync();
    void Dispose();
    Task<IDbContextTransaction> BeginTransactionAsync(CancellationToken cancellationToken = default);
    Task RollbackTransactionAsync();
    Task CommitTransactionAsync();
}