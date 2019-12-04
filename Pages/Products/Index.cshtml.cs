using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProductApp.Models;

namespace ProductApp.Pages.Products
{
    public abstract class IndexModel : PageModel
    {
        private readonly ProductApp.Data.ProductContext _context;

        public IndexModel(ProductApp.Data.ProductContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; }

        public async Task OnGetAsync()
        {
            Product = await _context.Products.ToListAsync();
        }
    }
}
