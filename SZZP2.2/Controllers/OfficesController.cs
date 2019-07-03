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
    }
}

