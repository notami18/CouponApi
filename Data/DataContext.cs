using Coupon.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Coupon.Api.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) {}

        public DbSet<Value> values { get; set; }
    }
}