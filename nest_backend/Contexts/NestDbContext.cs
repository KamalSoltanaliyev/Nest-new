using Microsoft.EntityFrameworkCore;

namespace nest_backend.Contexts
{
    public class NestDbContext : DbContext
    {
        public NestDbContext(DbContextOptions<NestDbContext> options) : base(options) 
        {
        }
    }
}
