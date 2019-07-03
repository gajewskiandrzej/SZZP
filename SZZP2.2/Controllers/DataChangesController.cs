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
    public class DataChangesController : Controller
    {
        private readonly SZZPContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public DataChangesController(SZZPContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: DataChanges
        public async Task<IActionResult> Index(string AddNrSAP)
        {
            int counter = 0;
            foreach (DataChange mod in _context.DataChanges)
            {
                if (mod.NrSap == AddNrSAP)
                {
                    counter++;
                }
            }

            if (counter == 0)
            {
                AddADUsersToModyfication(AddNrSAP);
            }

            var viewModel = new DataChangeIndexData();

            if (await _userManager.IsInRoleAsync(await _userManager.FindByNameAsync(User.Identity.Name), "PracownikHR"))
            {
                viewModel.DataChanges = await _context.DataChanges
                    .Include(e => e.Offices)
                        .ThenInclude(e => e.Departments)
                    .Include(e => e.Statuses)
                    .Where(e => e.IDStatus == 1)
                    .AsNoTracking()
                    .ToListAsync();
            }
            else if (await _userManager.IsInRoleAsync(await _userManager.FindByNameAsync(User.Identity.Name), "AdministratorAD"))
            {
                viewModel.DataChanges = await _context.DataChanges
                   .Include(e => e.Offices)
                       .ThenInclude(e => e.Departments)
                   .Include(e => e.Statuses)
                   .Where(e => e.IDStatus == 2 || e.IDStatus == 3)
                   .AsNoTracking()
                   .ToListAsync();
            }
            else if (await _userManager.IsInRoleAsync(await _userManager.FindByNameAsync(User.Identity.Name), "AdministratorAplikacji"))
            {
                viewModel.DataChanges = await _context.DataChanges
                   .Include(e => e.Offices)
                       .ThenInclude(e => e.Departments)
                   .Include(e => e.Statuses)
                   .AsNoTracking()
                   .ToListAsync();
            }

            return View(viewModel);
        }



        public IEnumerable AddADUsersToModyfication(string findNrSap)
        {
            var adUsers =
             (
                 from adusers in _context.ADUsers
                 where adusers.NrSap == findNrSap
                 select new DataChange
                 {
                     NrSap = adusers.NrSap,
                     DateChange = DateTime.Today,
                     Name = adusers.Name,
                     Surname = adusers.Surname,
                     IDOffice = adusers.IDOffice,
                     IDDepartment = adusers.IDDepartment,
                     EndContract = adusers.EndContract,
                     IDStatus = 1
                 }).ToList();


            _context.DataChanges.AddRange(adUsers);
            _context.SaveChanges();
            return (adUsers);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var dataChange = await _context.DataChanges.FindAsync(id);
            _context.DataChanges.Remove(dataChange);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        // GET: DataChanges/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            List<Office> officessList = new List<Office>();

            //--------------------------------Getting Data form Database Using EntityFrameworkCore
            officessList = (from office in _context.Offices
                            select office).ToList();

            //-------------------------------Inserting Select Item in List
            officessList.Insert(0, new Office { IDOffice = 0, NameOffice = "Wybierz biuro" });

            //-------------------------------Assigning officessList to ViewBag.ListofOffice

            ViewBag.ListofOffice = officessList;


            PopulateStatusesDropDownList();

            var dataChange = await _context.DataChanges.FindAsync(id);
            if (dataChange == null)
            {
                return NotFound();
            }
            //ViewData["NrSap"] = new SelectList(_context.ADUsers, "NrSap", "NrSap", dataChange.NrSap);
            return View(dataChange);
        }

        // POST: DataChanges/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IDDataChange,DateChange,NrSap,Name,Surname,IDOffice,IDDepartment,EndContract,IDStatus")] DataChange dataChange)
        {
            if (id != dataChange.IDDataChange)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dataChange);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DataChangeExists(dataChange.IDDataChange))
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
            //ViewData["NrSap"] = new SelectList(_context.ADUsers, "NrSap", "NrSap", dataChange.NrSap);
            return View(dataChange);
        }



        private bool DataChangeExists(int id)
        {
            return _context.DataChanges.Any(e => e.IDDataChange == id);
        }

        private void PopulateStatusesDropDownList(object selectedStatus = null)
        {
            var statusesQuery = from s in _context.Statuses
                                orderby s.IDStatus
                                select s;
            ViewBag.IDStatus = new SelectList(statusesQuery.AsNoTracking(), "IDStatus", "NameStatus", selectedStatus);
        }

        private void PopulatePositionsDropDownList(object selectedPosition = null)
        {
            var positionsQuery = from p in _context.Positions
                                 orderby p.IDPosition
                                 select p;
            ViewBag.IDPosition = new SelectList(positionsQuery.AsNoTracking(), "IDPosition", "NamePosition", selectedPosition);
        }

        public IActionResult GetDepartment(int IDOffice)
        {
            List<Department> departmentsList = new List<Department>();

            //-----------------------------------Getting Data from Database Using EntityFramework
            departmentsList = (from department in _context.Departments
                               where department.IDOffice == IDOffice
                               select department).ToList();

            //-----------------------------------Inserting Select Item in List
            departmentsList.Insert(0, new Department { IDDepartment = 0, NameDepartment = "Wybierz wydział" });

            return Json(departmentsList);
        }

    }
}



//// GET: DataChanges/Details/5
//public async Task<IActionResult> Details(int? id)
//{
//    if (id == null)
//    {
//        return NotFound();
//    }

//    var dataChange = await _context.DataChanges
//        .Include(d => d.ADUsers)
//        .FirstOrDefaultAsync(m => m.IDDataChange == id);
//    if (dataChange == null)
//    {
//        return NotFound();
//    }

//    return View(dataChange);
//}

//// GET: DataChanges/Create
//public IActionResult Create()
//{
//    ViewData["NrSap"] = new SelectList(_context.ADUsers, "NrSap", "NrSap");
//    return View();
//}

//GET: ADUsers/Create



//// POST: DataChanges/Create
//// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
//// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
//[HttpPost]
//[ValidateAntiForgeryToken]
//public async Task<IActionResult> Create([Bind("IDDataChange,DateChange,NrSap,Name,Surname,IDOffice,IDDepartment,StatusDataChange")] DataChange dataChange)
//{
//    if (ModelState.IsValid)
//    {
//        _context.Add(dataChange);
//        await _context.SaveChangesAsync();
//        return RedirectToAction(nameof(Index));
//    }
//    ViewData["NrSap"] = new SelectList(_context.ADUsers, "NrSap", "NrSap", dataChange.NrSap);
//    return View(dataChange);
//}

//// GET: DataChanges/Delete/5
//public async Task<IActionResult> Delete(int? id)
//{
//    if (id == null)
//    {
//        return NotFound();
//    }

//    var dataChange = await _context.DataChanges
//        .Include(d => d.ADUsers)
//        .FirstOrDefaultAsync(m => m.IDDataChange == id);
//    if (dataChange == null)
//    {
//        return NotFound();
//    }

//    return View(dataChange);
//}

// POST: DataChanges/Delete/5
