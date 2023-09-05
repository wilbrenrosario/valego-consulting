using Microsoft.EntityFrameworkCore;
using valego.core.Models;

namespace valego.application
{
    public interface IApplicationDbContext 
    {
        public DbSet<Announcement> Announcement { get; set; }
        Task<int> SaveChangesAsync();
    }
}
