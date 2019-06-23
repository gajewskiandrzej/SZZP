using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using SZZP2._2.Data;
using SZZP2._2.Models;

namespace SZZP2._2.Controllers
{
    public class ADUsersController : Controller
    {
        private readonly SZZPContext _context;

        public ADUsersController(SZZPContext context)
        {
            _context = context;
        }

        // GET: ADUsers
        public async Task<IActionResult> Index()
        {
            var sZZPContext = _context.ADUsers.Include(a => a.Office);
            return View(await sZZPContext.ToListAsync());
        }


        //GET: ADUsers/Create
        [HttpGet]
        public IActionResult AddADUsers()
        {
            var adUsers =
             (
                 from employment in _context.Employments
                 where employment.IDStatus == 3
                 select new ADUser
                 {
                     NrSap = employment.NrSap,
                     Name = employment.Name,
                     Surname = employment.Surname,
                     DateEmployment = employment.DateEmployment,
                     EndContract = employment.EndContract,
                     IDOffice = employment.IDOffice,
                     IDDepartment = employment.IDDepartment
                 }).ToList();

            //if (ModelState.IsValid)
            //{

            _context.ADUsers.AddRange(adUsers);
            _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
