using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SZZP2._2.Data;
using SZZP2._2.Models;
using SZZP2._2.Models.SZZPViewModels;

namespace SZZP2._2.Controllers
{
    [Authorize]
    public class DismissalController : Controller
    {
        private readonly SZZPContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public DismissalController(SZZPContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: DataChanges
        public async Task<IActionResult> Index(string AddNrSAP)
        {
            int counter = 0;
            foreach (Dismissal mod in _context.Dismissals)
            {
                if (mod.NrSap == AddNrSAP)
                {
                    counter++;
                }
            }

            if (counter == 0)
            {
                AddADUsersToDelete(AddNrSAP);
            }

            var viewModel = new DissmisalIndexData();

            if (await _userManager.IsInRoleAsync(await _userManager.FindByNameAsync(User.Identity.Name), "PracownikHR"))
            {
                viewModel.Dismissals = await _context.Dismissals
                    .Include(e => e.Offices)
                        .ThenInclude(e => e.Departments)
                    .Include(e => e.Statuses)
                    .Where(e => e.IDStatus == 1)
                    .AsNoTracking()
                    .ToListAsync();
            }
            else if (await _userManager.IsInRoleAsync(await _userManager.FindByNameAsync(User.Identity.Name), "AdministratorAD"))
            {
                viewModel.Dismissals = await _context.Dismissals
                   .Include(e => e.Offices)
                       .ThenInclude(e => e.Departments)
                   .Include(e => e.Statuses)
                   .Where(e => e.IDStatus == 2 || e.IDStatus == 3)
                   .AsNoTracking()
                   .ToListAsync();
            }
            else if (await _userManager.IsInRoleAsync(await _userManager.FindByNameAsync(User.Identity.Name), "AdministratorAplikacji"))
            {
                viewModel.Dismissals = await _context.Dismissals
                   .Include(e => e.Offices)
                       .ThenInclude(e => e.Departments)
                   .Include(e => e.Statuses)
                   .AsNoTracking()
                   .ToListAsync();
            }

            return View(viewModel);
        }

        public IEnumerable AddADUsersToDelete(string findNrSap)
        {
            var adUsers =
             (
                 from adusers in _context.ADUsers
                 where adusers.NrSap == findNrSap
                 select new Dismissal
                 {
                     NrSap = adusers.NrSap,
                     Name = adusers.Name,
                     Surname = adusers.Surname,
                     IDOffice = adusers.IDOffice,
                     IDDepartment = adusers.IDDepartment,
                     EndContract = adusers.EndContract,
                     IDStatus = 1
                 }).ToList();


            _context.Dismissals.AddRange(adUsers);
            _context.SaveChanges();
            return (adUsers);
        }

        public async Task<IActionResult> ChangeStatus(int id)
        {
            var dismissal = await _context.Dismissals.FindAsync(id);
            dismissal.IDStatus = 2;
            _context.Dismissals.Update(dismissal);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int id)
        {
            var dismissal = await _context.Dismissals.FindAsync(id);
            _context.Dismissals.Remove(dismissal);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DismissalExists(int id)
        {
            return _context.Dismissals.Any(e => e.IDDismissal == id);
        }
    }
}




