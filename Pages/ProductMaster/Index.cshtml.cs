using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CRUDRazorPages.DAL;
using CRUDRazorPages.Models;

namespace CRUDRazorPages.Pages.ProductMaster
{
    public class IndexModel : PageModel
    {
        private readonly CRUDRazorPages.DAL.AppDbContext _context;

        public IndexModel(CRUDRazorPages.DAL.AppDbContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Product = await _context.Products.ToListAsync();
        }
    }
}
