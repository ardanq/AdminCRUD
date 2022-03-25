using AdminCRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace AdminCRUD.Data
{
    public class AdminCRUDContext:DbContext
    {
        public AdminCRUDContext(DbContextOptions<AdminCRUDContext> options) : base(options) { }

        public virtual DbSet<Product> Products { get; set; }
    }
}
