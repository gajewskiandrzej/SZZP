using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using SZZP2._2.Data;
using SZZP2._2.Models;

namespace SZZP2._2.Controllers
{
    public class APPUsersController : Controller
    {
        private readonly SZZPContext _context;

        public APPUsersController(SZZPContext context)
        {
            _context = context;
        }

        // GET: APPUsers
        public async Task<IActionResult> Index()
        {
            var sZZPContext = _context.APPUSers.Include(a => a.Roles);
            return View(await sZZPContext.ToListAsync());
        }

        // GET: APPUsers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aPPUser = await _context.APPUSers
                .Include(a => a.Roles)
                .FirstOrDefaultAsync(m => m.IDAPPUser == id);
            if (aPPUser == null)
            {
                return NotFound();
            }

            return View(aPPUser);
        }

        // GET: APPUsers/Create
        public IActionResult Create()
        {
            //ViewData["IDRole"] = new SelectList(_context.Roles, "IDRole", "IDRole");
            PopulateRolesDropDownList();
            return View();
        }

        // POST: APPUsers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IDAPPUser,Login,Password,IDRole")] APPUser aPPUser)
        {
            if (ModelState.IsValid)
            {
                _context.Add(aPPUser);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            //ViewData["IDRole"] = new SelectList(_context.Roles, "IDRole", "IDRole", aPPUser.IDRole);
            PopulateRolesDropDownList(aPPUser.IDRole);
            return View(aPPUser);
        }

        // GET: APPUsers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aPPUser = await _context.APPUSers.FindAsync(id);
            if (aPPUser == null)
            {
                return NotFound();
            }
            //ViewData["IDRole"] = new SelectList(_context.Roles, "IDRole", "IDRole", aPPUser.IDRole);
            PopulateRolesDropDownList(aPPUser.IDRole);
            return View(aPPUser);
        }

        // POST: APPUsers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IDAPPUser,Login,Password,IDRole")] APPUser aPPUser)
        {
            if (id != aPPUser.IDAPPUser)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(aPPUser);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!APPUserExists(aPPUser.IDAPPUser))
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
            ViewData["IDRole"] = new SelectList(_context.Roles, "IDRole", "IDRole", aPPUser.IDRole);
            return View(aPPUser);
        }

        // GET: APPUsers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aPPUser = await _context.APPUSers
                .Include(a => a.Roles)
                .FirstOrDefaultAsync(m => m.IDAPPUser == id);
            if (aPPUser == null)
            {
                return NotFound();
            }

            return View(aPPUser);
        }

        // POST: APPUsers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var aPPUser = await _context.APPUSers.FindAsync(id);
            _context.APPUSers.Remove(aPPUser);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool APPUserExists(int id)
        {
            return _context.APPUSers.Any(e => e.IDAPPUser == id);
        }

        private void PopulateRolesDropDownList(object selectedRole = null)
        {
            var roleQuery = from r in _context.Roles
                            orderby r.NameRole
                            select r;
            ViewBag.IDRole = new SelectList(roleQuery.AsNoTracking(), "IDRole", "NameRole", selectedRole);
        }
    }
}
