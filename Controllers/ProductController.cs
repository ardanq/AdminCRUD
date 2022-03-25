using AdminCRUD.Data;
using Microsoft.AspNetCore.Mvc;

namespace AdminCRUD.Controllers
{
    public class ProductController : Controller
    {
        private readonly AdminCRUDContext _context;

        public ProductController(AdminCRUDContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
