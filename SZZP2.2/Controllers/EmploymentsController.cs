﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using SZZP2._2.Data;
using SZZP2._2.Models;
using SZZP2._2.Models.SZZPViewModels;

namespace SZZP2._2.Controllers
{
    public class EmploymentsController : Controller
    {
        private readonly SZZPContext _context;

        public EmploymentsController(SZZPContext context)
        {
            _context = context;
        }

        // GET: Employments
        public async Task<IActionResult> Index(int id)
        {
            //var sZZPContext = _context.Employments
            //    .Include(e => e.Offices)
            //        .ThenInclude(e => e.Departments)
            //    .Include(e => e.Positions)
            //    .Include(e => e.Statuses);
            //return View(await sZZPContext.ToListAsync());
            
            var viewModel = new EmploymentIndexData();
            viewModel.Employments = await _context.Employments
                .Include(e => e.Offices)
                    .ThenInclude(e => e.Departments)
                .Include(e => e.Positions)
                .Include(e => e.Statuses)
            .AsNoTracking()
            .ToListAsync();

            return View(viewModel);
        }

        // GET: Employments/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employment = await _context.Employments
                .Include(e => e.Offices)
                .FirstOrDefaultAsync(m => m.IDEmployment == id);
            if (employment == null)
            {
                return NotFound();
            }

            return View(employment);
        }

        // GET: Employments/Create
        public IActionResult Create()
        {
            PopulateOfficesDropDownList();
            PopulateStatusesDropDownList();
            PopulatePositionsDropDownList();
            PopulateDepartmentsDropDownList();
            
            
            
            //ViewData["IDOffice"] = new SelectList(_context.Offices, "IDOffice", "IDOffice");
            return View();
        }

        // POST: Employments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IDEmployment,Name,Surname,NrSap,DateEmployment,EndContract,IDOffice,OfficeSymbol,IDDepartment,IDPosition,IDStatus")] Employment employment)
        {
            if (ModelState.IsValid)
            {
                _context.Add(employment);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            PopulateOfficesDropDownList(employment.IDOffice);
            PopulateStatusesDropDownList(employment.IDStatus);
            PopulatePositionsDropDownList(employment.IDPosition);
            PopulateDepartmentsDropDownList(employment.IDDepartment);
            //ViewData["IDOffice"] = new SelectList(_context.Offices, "IDOffice", "IDOffice", employment.IDOffice);
            return View(employment);
        }

        // GET: Employments/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            PopulateOfficesDropDownList();
            PopulateStatusesDropDownList();
            PopulatePositionsDropDownList();
            PopulateDepartmentsDropDownList();

            //if (id == null)
            //{
            //    return NotFound();
            //}

            var employment = await _context.Employments.FindAsync(id);
            if (employment == null)
            {
                return NotFound();
            }
            //ViewData["IDOffice"] = new SelectList(_context.Offices, "IDOffice", "IDOffice", employment.IDOffice);
            return View(employment);
        }

        // POST: Employments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IDEmployment,Name,Surname,NrSap,DateEmployment,EndContract,IDOffice,OfficeSymbol,IDDepartment,IDPosition,IDStatus")] Employment employment)
        {
            if (id != employment.IDEmployment)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(employment);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmploymentExists(employment.IDEmployment))
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
            //ViewData["IDOffice"] = new SelectList(_context.Offices, "IDOffice", "IDOffice", employment.IDOffice);

            PopulateOfficesDropDownList(employment.IDOffice);
            PopulateStatusesDropDownList(employment.IDStatus);
            PopulatePositionsDropDownList(employment.IDPosition);
            PopulateDepartmentsDropDownList(employment.IDDepartment);

            return View(employment);
        }

        // GET: Employments/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employment = await _context.Employments
                .Include(e => e.Offices)
                    .ThenInclude(e => e.Departments)
                .Include(e => e.Positions)
                .Include(e => e.Statuses)
                .FirstOrDefaultAsync(m => m.IDEmployment == id);
            if (employment == null)
            {
                return NotFound();
            }

            return View(employment);
        }

        // POST: Employments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var employment = await _context.Employments.FindAsync(id);
            _context.Employments.Remove(employment);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmploymentExists(int id)
        {
            return _context.Employments.Any(e => e.IDEmployment == id);
        }

        private void PopulateOfficesDropDownList(object selectedOffice = null)
        {
            var officesQuery = from d in _context.Offices
                               orderby d.NameOffice
                               select d;
            ViewBag.IDOffice = new SelectList(officesQuery.AsNoTracking(), "IDOffice", "NameOffice", selectedOffice);
        }

        private void PopulateStatusesDropDownList(object selectedStatus = null)
        {
            var statusesQuery = from s in _context.Statuses
                                orderby s.IDStatus
                                select s;
            ViewBag.IDStatus = new SelectList(statusesQuery.AsNoTracking(),"IDStatus", "NameStatus", selectedStatus);
        }

        private void PopulatePositionsDropDownList(object selectedPosition = null)
        {
            var positionsQuery = from p in _context.Positions
                                 orderby p.IDPosition
                                 select p;
            ViewBag.IDPosition = new SelectList(positionsQuery.AsNoTracking(), "IDPosition", "NamePosition", selectedPosition);
        }

        private void PopulateDepartmentsDropDownList(object selectedDepartment = null)
        {
            var departmentsQuery = from d in _context.Departments
                                   orderby d.NameDepartment
                                   select d;
            ViewBag.IDDepartment = new SelectList(departmentsQuery.AsNoTracking(), "IDDepartment", "NameDepartment", selectedDepartment);
        }

        private void GetDepartmentName(int idOffice)
        {
            var departmentNameQuery = from d in _context.Departments
                                      where d.IDOffice == idOffice
                                      select d.NameDepartment;
            ViewBag.NameDepartment = departmentNameQuery;
        }
    }
}
