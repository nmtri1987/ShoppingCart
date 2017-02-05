using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ShoppingCart.Data
{
    public class ItemContext : DbContext
    {
        public ItemContext(DbContextOptions<ItemContext> options)
            : base(options) { }
        public ItemContext() { }
        public DbSet<ItemDetails> ItemDetails { get; set; }
    }
}
