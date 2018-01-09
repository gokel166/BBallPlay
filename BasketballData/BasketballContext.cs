using System;
using Microsoft.EntityFrameworkCore;
using BasketballData.Models;

namespace BasketballData
{
    public class BasketballContext : DbContext
    {
        public BasketballContext(DbContextOptions options) : base(options){ }

        public DbSet<Players> Player { get; set; }
    }
}
