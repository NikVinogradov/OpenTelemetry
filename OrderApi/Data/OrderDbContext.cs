using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OrderApi;

    public class OrderDbContext : DbContext
    {
        public OrderDbContext (DbContextOptions<OrderDbContext> options)
            : base(options)
        {
        }

        public DbSet<OrderApi.Order> Order { get; set; } = default!;
    }
