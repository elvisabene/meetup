using Meetup.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace Meetup.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Event> Events { get; set; } = null!;

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
    }
}
