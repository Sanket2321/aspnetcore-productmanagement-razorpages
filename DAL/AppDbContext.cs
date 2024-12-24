using CRUDRazorPages.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUDRazorPages.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
            
        }
        public  DbSet<Product> Products { get; set; }
    }
}
