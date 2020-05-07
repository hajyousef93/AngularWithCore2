using Microsoft.EntityFrameworkCore;
using Zwaj2.Models;

namespace Zwaj2.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext>options):base(options)
        {
            
        }
        public DbSet<Value> Values { get; set; }
    }
}