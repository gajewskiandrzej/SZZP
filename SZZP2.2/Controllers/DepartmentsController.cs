using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using SZZP2._2.Data;
using SZZP2._2.Models;

namespace SZZP2._2.Controllers
{
    [Authorize(Roles = "AdministratorAplikacji")]
    public class DepartmentsController : Controller
    {
        private readonly SZZPContext _context;

        public DepartmentsController(SZZPContext context)
        {
            _context = context;
        }

        // GET: Departments
        public async Task<IActionResult> Index()
        {
            var sZZPContext = _context.Departments.Include(d => d.Offices);
            return View(await sZZPContext.ToListAsync());
        }

        // GET: Departments/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var department = await _context.Departments
                .Include(d => d.Offices)
                .FirstOrDefaultAsync(m => m.IDDepartment == id);
            if (department == null)
            {
                return NotFound();
            }

            return View(department);
        }

        // GET: Departments/Create
        public IActionResult Create()
        {
            PopulateOfficesDropDownList();
            return View();
        }

        // POST: Departments/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IDDepartment,IDOffice,NameDepartment,SymbolDeprtament")] Department department)
        {
            if (ModelState.IsValid)
            {
                _context.Add(department);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            PopulateOfficesDropDownList(department.IDOffice);
            return View(department);
        }

        // GET: Departments/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var department = await _context.Departments.FindAsync(id);
            if (department == null)
            {
                return NotFound();
            }
            PopulateOfficesDropDownList(department.IDOffice);
            return View(department);
        }

        // POST: Departments/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IDDepartment,IDOffice,NameDepartment,SymbolDeprtament")] Department department)
        {
            if (id != department.IDDepartment)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(department);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DepartmentExists(department.IDDepartment))
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
            ViewData["IDOffice"] = new SelectList(_context.Offices, "IDOffice", "IDOffice", department.IDOffice);

            return View(department);
        }

        // GET: Departments/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var department = await _context.Departments
                .Include(d => d.Offices)
                .FirstOrDefaultAsync(m => m.IDDepartment == id);
            if (department == null)
            {
                return NotFound();
            }

            return View(department);
        }

        // POST: Departments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var department = await _context.Departments.FindAsync(id);
            _context.Departments.Remove(department);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DepartmentExists(int id)
        {
            return _context.Departments.Any(e => e.IDDepartment == id);
        }

        private void PopulateOfficesDropDownList(object selectedOffice = null)
        {
            var officesQuery = from d in _context.Offices
                               orderby d.NameOffice
                               select d;
            ViewBag.IDOffice = new SelectList(officesQuery.AsNoTracking(), "IDOffice", "NameOffice", selectedOffice);
        }
    }
}
