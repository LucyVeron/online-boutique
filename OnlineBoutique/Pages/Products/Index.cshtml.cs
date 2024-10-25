using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using OnlineBoutique.Data;
using OnlineBoutique.Models;

namespace OnlineBoutique.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly OnlineBoutique.Data.OnlineBoutiqueContext _context;

        public IndexModel(OnlineBoutique.Data.OnlineBoutiqueContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Product = await _context.Product.ToListAsync();
        }
    }
}
