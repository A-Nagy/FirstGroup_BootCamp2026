using FirstGroup_1.Application.Abstractions.Repositories;
 
using FirstGroup_1.Domain;
using FirstGroup_1.Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;

namespace FirstGroup_1.Controllers
{
    public class CategoriesController : Controller
    {
        //  private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unit;

        public CategoriesController(ApplicationDbContext context, IUnitOfWork unit)
        {
           // _context = context;
            _unit = unit;
        }

        [HttpGet]
        public IActionResult Index()
        {
            IEnumerable<Category> categories = _unit.Categories.GetAll();
            return View(categories);
        }
        //Get : Category Deatils
        public IActionResult Details(int Id)
        {
            Category? cat = _unit.Categories.GetById(Id);
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
                _unit.Categories.Add(cat);
                _unit.Save();

                return RedirectToAction("Index");
            }
            return View(cat);

        }

        [HttpGet]
        public IActionResult Update(int Id)
        {
            Category? category = _unit.Categories.GetById(Id);
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
                _unit.Categories.Update(cat);
                _unit.Save();
                return RedirectToAction("Index");
            }
            return View(cat);
        }
        [HttpGet]
        public IActionResult Delete(int Id)
        {
            Category? cat = _unit.Categories.GetById(Id);
            if (cat == null)
            {
                return NotFound();
            }
            return View(cat);
        }
        [HttpPost]
        public IActionResult Delete(Category cat)
        {

            _unit.Categories.Delete(cat);
            _unit.Save();
            return RedirectToAction("Index");


        }
    }
}
