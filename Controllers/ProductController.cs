using AdminCRUD.Data;
using AdminCRUD.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
            List<Product> products = _context.Products.ToList();
            return View(products);
        }

        [HttpGet]
        public IActionResult Create()
        {
            Product prod = new Product();
            return View(prod);
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            _context.Add(product);
            _context.SaveChanges();
            return RedirectToAction("index");
        }

        public IActionResult Details(int Id)
        {
            Product prod = _context.Products.Where(x => x.Id == Id).FirstOrDefault();
            return View(prod);
        }

        [HttpGet]
        public IActionResult Edit(int Id)
        {
            Product prod = _context.Products.Where(x => x.Id == Id).FirstOrDefault();
            return View(prod);
        }

        [HttpPost]
        public IActionResult Edit(Product product)
        {
            _context.Attach(product);
            _context.Entry(product).State = EntityState.Modified;
            _context.SaveChanges();
            return RedirectToAction("index");
        }




    }
}
