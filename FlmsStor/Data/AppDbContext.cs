
using Microsoft.EntityFrameworkCore;

namespace FlmsStor.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
    }
}
