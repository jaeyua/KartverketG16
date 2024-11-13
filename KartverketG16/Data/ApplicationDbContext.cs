using Microsoft.EntityFrameworkCore;

namespace KartverketG16.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}
