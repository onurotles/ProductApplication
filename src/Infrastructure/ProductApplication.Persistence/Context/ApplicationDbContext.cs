using Microsoft.EntityFrameworkCore;
using ProductApplication.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApplication.Persistence.Context
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
