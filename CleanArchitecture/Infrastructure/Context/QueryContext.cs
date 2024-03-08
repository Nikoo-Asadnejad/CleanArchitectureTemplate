using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Context;

public class QueryContext : DbContext
{
    public QueryContext(DbContextOptions<QueryContext> options) : base(options)
    {
        
    }
    
}