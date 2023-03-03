using CardRequestAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CardRequestAPI.Data
{
    public class RequestCardContext : DbContext
    {
        public RequestCardContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<RequestCardEntity> RequestCards { get; set; }
    }
}
