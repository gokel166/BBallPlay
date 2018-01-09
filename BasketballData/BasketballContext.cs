using System;
using Microsoft.EntityFrameworkCore;

namespace BasketballData
{
    public class BasketballContext : DbContext
    {
        public BasketballContext(DbContextOptions options) : base(options){ }

        public DbSet<Player> MyProperty { get; set; }
    }
}
