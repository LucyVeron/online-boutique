using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OnlineBoutique.Models;

namespace OnlineBoutique.Data
{
    public class OnlineBoutiqueContext : DbContext
    {
        public OnlineBoutiqueContext (DbContextOptions<OnlineBoutiqueContext> options)
            : base(options)
        {
        }

        public DbSet<OnlineBoutique.Models.Product> Product { get; set; } = default!;
    }
}
