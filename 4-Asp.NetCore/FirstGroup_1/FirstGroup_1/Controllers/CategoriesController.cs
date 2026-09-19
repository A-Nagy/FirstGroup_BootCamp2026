using FirstGroup_1.Data;
using FirstGroup_1.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstGroup_1.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CategoriesController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            List<Category> categories = _context.Categories.ToList();
            return View(categories);
        }
        //Get : Category Deatils
        public IActionResult Details(int Id)
        {
            Category? cat = _context.Categories.Find(Id);
            if (cat == null)
            {
                return NotFound();
            }
            return View(cat);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Category cat)
        {
            if (ModelState.IsValid)
            {
                _context.Categories.Add(cat);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(cat);

        }

        [HttpGet]
        public IActionResult Update(int Id)
        {
            Category? category = _context.Categories.Find(Id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }
        [HttpPost]
        public IActionResult Update(Category cat)
        {
            if (ModelState.IsValid)
            {
                _context.Categories.Update(cat);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cat);
        }
        [HttpGet]
        public IActionResult Delete(int Id)
        {
            Category? cat = _context.Categories.Find(Id);
            if (cat == null)
            {
                return NotFound();
            }
            return View(cat);
        }
        [HttpPost]
        public IActionResult Delete(Category cat)
        {

            _context.Categories.Remove(cat);
            _context.SaveChanges();
            return RedirectToAction("Index");


        }
    }
}
