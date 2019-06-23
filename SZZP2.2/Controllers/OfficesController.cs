using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using SZZP2._2.Data;
using SZZP2._2.Models;


namespace SZZP2._2.Controllers
{
    [Authorize]
    public class OfficesController : Controller
    {
        private readonly SZZPContext _context;

        public OfficesController(SZZPContext context)
        {
            _context = context;
        }

        // GET: Offices
        [Authorize(Roles = "AdministratorAplikacji")]
        public async Task<IActionResult> Index()
        {
            return View(await _context.Offices.ToListAsync());
        }

        // GET: Offices/Details/5
        public async Task<IActionResult> Details(int id)
        {

            var office = await _context.Offices
                .Include(o => o.Departments)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.IDOffice == id);

            if (office == null)
            {
                return NotFound();
            }

            return View(office);

        }

        // GET: Offices/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Offices/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IDOffice,NameOffice,SymbolOffice")] Office office)
        {
            if (ModelState.IsValid)
            {
                _context.Add(office);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(office);
        }

        // GET: Offices/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var office = await _context.Offices.FindAsync(id);
            if (office == null)
            {
                return NotFound();
            }
            return View(office);
        }

        // POST: Offices/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IDOffice,NameOffice,SymbolOffice")] Office office)
        {
            if (id != office.IDOffice)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(office);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OfficeExists(office.IDOffice))
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
            return View(office);
        }

        // GET: Offices/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var office = await _context.Offices
                .FirstOrDefaultAsync(m => m.IDOffice == id);
            if (office == null)
            {
                return NotFound();
            }

            return View(office);
        }

        // POST: Offices/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var office = await _context.Offices.FindAsync(id);
            _context.Offices.Remove(office);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OfficeExists(int id)
        {
            return _context.Offices.Any(e => e.IDOffice == id);
        }

    //    // GET: Departments/Create
    //    public IActionResult CreateDepartment()
    //    {
    //        ViewData["IDOffice"] = new SelectList(_context.Offices, "IDOffice", "IDOffice");
    //        return View();
    //    }

    //    // POST: Departments/Create
    //    // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
    //    // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
    //    [HttpPost]
    //    [ValidateAntiForgeryToken]
    //    public async Task<IActionResult> CreateDepartment([Bind("IDDepartment,IDOffice,NameDepartment,SymbolDeprtament")] Department department)
    //    {
    //        if (ModelState.IsValid)
    //        {
    //            _context.Add(department);
    //            await _context.SaveChangesAsync();
    //            return RedirectToAction(nameof(Details));
    //        }
    //        ViewData["IDOffice"] = new SelectList(_context.Offices, "IDOffice", "IDOffice", department.IDOffice);         
    //        return View(department);
    //    }

    //    // GET: Departments/Edit/5
    //    public async Task<IActionResult> EditDepartment(int? id)
    //    {
    //        if (id == null)
    //        {
    //            return NotFound();
    //        }

    //        var department = await _context.Departments.FindAsync(id);
    //        if (department == null)
    //        {
    //            return NotFound();
    //        }
    //        ViewData["IDOffice"] = new SelectList(_context.Offices, "IDOffice", "IDOffice", department.IDOffice);
    //        return View(department);
    //    }

    //    // POST: Departments/Edit/5
    //    // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
    //    // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
    //    [HttpPost]
    //    [ValidateAntiForgeryToken]
    //    public async Task<IActionResult> EditDepartment(int id, [Bind("IDDepartment,IDOffice,NameDepartment,SymbolDeprtament")] Department department)
    //    {
    //        if (id != department.IDDepartment)
    //        {
    //            return NotFound();
    //        }

    //        if (ModelState.IsValid)
    //        {
    //            try
    //            {
    //                _context.Update(department);
    //                await _context.SaveChangesAsync();
    //            }
    //            catch (DbUpdateConcurrencyException)
    //            {
    //                if (!DepartmentExists(department.IDDepartment))
    //                {
    //                    return NotFound();
    //                }
    //                else
    //                {
    //                    throw;
    //                }
    //            }
    //            return RedirectToAction(nameof(Details));
    //        }
    //        ViewData["IDOffice"] = new SelectList(_context.Offices, "IDOffice", "IDOffice", department.IDOffice);
    //        return View(department);
    //    }

    //    // GET: Departments/Delete/5
    //    public async Task<IActionResult> DeleteDepartment(int? id)
    //    {
    //        if (id == null)
    //        {
    //            return NotFound();
    //        }

    //        var department = await _context.Departments
    //            .Include(d => d.Offices)
    //            .FirstOrDefaultAsync(m => m.IDDepartment == id);
    //        if (department == null)
    //        {
    //            return NotFound();
    //        }

    //        return View(department);
    //    }

    //    // POST: Departments/Delete/5
    //    [HttpPost, ActionName("DeleteDepartment")]
    //    [ValidateAntiForgeryToken]
    //    public async Task<IActionResult> DeleteDepartmentConfirmed(int id)
    //    {
    //        var department = await _context.Departments.FindAsync(id);
    //        _context.Departments.Remove(department);
    //        await _context.SaveChangesAsync();
    //        return RedirectToAction(nameof(Details));
    //    }

    //    private bool DepartmentExists(int id)
    //    {
    //        return _context.Departments.Any(e => e.IDDepartment == id);
    //    }
    }
}

