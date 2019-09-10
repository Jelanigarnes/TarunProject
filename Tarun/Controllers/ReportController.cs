using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tarun.Models;
using Tarun.Services;

namespace Tarun.Controllers
{
    public class ReportController : Controller
    {
        private readonly IReport _Report;

        public ReportController(IReport _IReport)
        {
            _Report = _IReport;
        }
        public IActionResult Index()
        {
            return View(_Report.GetReports);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Report model)
        {
            if (ModelState.IsValid)
            {
                _Report.Add(model);
                return RedirectToAction("Index");
            }
            return View(model);

        }
    }
}