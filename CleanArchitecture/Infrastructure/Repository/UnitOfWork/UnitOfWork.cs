using Application.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository.UnitOfWork;

public class UnitOfWork : IUnitOfWork
{
    private readonly DbContext _context;
    public UnitOfWork(DbContext context)
    {
        _context = context;
    }

    public async Task SaveAsync()
        => await _context.SaveChangesAsync();

    public async Task DisposeAsync()
        => await _context.DisposeAsync();
}