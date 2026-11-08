using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstGroup_1.Application.Abstractions.Repositories;
using FirstGroup_1.Domain;
using FirstGroup_1.Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
 
namespace FirstGroup_1.Controllers
{
    public class UsersController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IUsersRepository _usersRepository;
        private readonly IRepository<User> _userRepository;

        public UsersController(ApplicationDbContext context, IUsersRepository repo , IRepository<User> userRepository)
        {
            _context = context;
            _usersRepository = repo;
            _userRepository = userRepository;
        }

        // GET: Users
        public async Task<IActionResult> Index()
        {/*await _context.Users.ToListAsync()*/
            return View(_usersRepository.GetAll());
        }

        // GET: Users/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
/*await _context.Users.FirstOrDefaultAsync(m => m.Id == id);*/
            var user = _usersRepository.GetById(id.Value);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // GET: Users/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Users/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Email,Phone,Username,Password")] User user)
        {
            if (ModelState.IsValid)
            {
                _usersRepository.Add(user);
                //_context.Add(user);
                //await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }

        // GET: Users/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            /* await _context.Users.FindAsync(id);*/

            var user = _usersRepository.GetById(id.Value);

            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        // POST: Users/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Email,Phone,Username,Password")] User user)
        {
            if (id != user.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _usersRepository.Update(user);
                    //_context.Update(user);
                    //await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserExists(user.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }

        // GET: Users/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            /*await _context.Users.FirstOrDefaultAsync(m => m.Id == id);*/
            var user = _usersRepository.GetById(id.Value);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // POST: Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user != null)
            {
                _usersRepository.Delete(user);
                //_context.Users.Remove(user);
            }

            //await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserExists(int id)
        {
            return _context.Users.Any(e => e.Id == id);
        }

        /// Task Make Assign Roles  (Like Assign Permissions)
        /// 
        [HttpGet]
        public IActionResult AssignRole(int Id)
        {/* _context.Users.Include(u => u.Roles).FirstOrDefault(u => u.Id == Id);*/
            User? user =_usersRepository.GetUserWithRoles(Id);
            if (user == null)
            {
                return NotFound();
            }

            List<Role> roles = _context.Roles.ToList();
            ViewBag.AllRoles = roles;

            ViewBag.UserRoles = user.Roles.Select(r => r.Id).ToList();

            return View(user);
        }
        [HttpPost]
        public IActionResult AssignRole(int Id, List<int> rolesIds)
        {/*_context.Users.Include(u => u.Roles).FirstOrDefault(u => u.Id == Id);*/
            User? user = _usersRepository.GetUserWithRoles(Id);
            if (user == null)
            {
                return NotFound();
            }
            user.Roles.Clear();

            List<Role> SelectRole = _context.Roles.Where(r => rolesIds.Contains(r.Id)).ToList();

            foreach (Role role in SelectRole)
            {
                user.Roles.Add(role);
                _usersRepository.Update(user);
            }
            //_context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
