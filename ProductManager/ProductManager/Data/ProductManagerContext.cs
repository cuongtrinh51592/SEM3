using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProductManager.Models;

namespace ProductManager.Data
{
    public class ProductManagerContext : DbContext
    {
        public ProductManagerContext (DbContextOptions<ProductManagerContext> options)
            : base(options)
        {
        }

        public DbSet<ProductManager.Models.Product> Product { get; set; }
    }
}
