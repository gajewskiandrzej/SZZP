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
            var viewModel = new ADUser();
            return View(await _context.ADUsers.ToListAsync());

        }


        //GET: ADUsers/Create
        [HttpGet]
        public ActionResult AddADUsers()
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

            var removeEmployment =
                (
                    from employment in _context.Employments
                    where employment.IDStatus == 3
                    select employment);

            foreach (var emp in removeEmployment)
            {
                _context.Employments.Remove(emp);
            }

            _context.ADUsers.AddRange(adUsers);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public ActionResult UpdateADUsers()
        {
            var adUsers =
             (
                 from datachange in _context.DataChanges
                 where datachange.IDStatus == 3
                 select new ADUser
                 {
                     NrSap = datachange.NrSap,
                     Name = datachange.Name,
                     Surname = datachange.Surname,
                     IDOffice = datachange.IDOffice,
                     IDDepartment = datachange.IDDepartment,
                     EndContract = datachange.EndContract
                 }).ToList();

            var removeDatachange =
                (
                    from datachange in _context.DataChanges
                    where datachange.IDStatus == 3
                    select datachange);

            foreach (var dch in removeDatachange)
            {
                _context.DataChanges.Remove(dch);
            }

            _context.ADUsers.UpdateRange(adUsers);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public ActionResult RemoveADUsers()
        {
            var adUsers =
             (
                 from adusers in _context.Dismissals
                 select new ADUser
                 {
                     NrSap = adusers.NrSap,
                     Name = adusers.Name,
                     Surname = adusers.Surname,
                     IDOffice = adusers.IDOffice,
                     IDDepartment = adusers.IDDepartment,
                     EndContract = adusers.EndContract
                 }).ToList();

            var removeDismissal =
                (
                    from dismissal in _context.Dismissals
                    where dismissal.IDStatus == 3
                    select dismissal);

            foreach (var dismiss in removeDismissal)
            {
                _context.Dismissals.Remove(dismiss);
            }

            _context.ADUsers.RemoveRange(adUsers);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
