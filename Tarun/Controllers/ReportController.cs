﻿using System;
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
            //return View(_Report.GetReports);
        }
        //[HttpPost]
        /*public string Index(string searchString, bool notUsed)
        {
            return "From [HttpPost]Index: filter on " + searchString;
        }*/

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
        [HttpGet]
        public IActionResult Delete(int? ID)
        {
            Report model = _Report.GetReport(ID);
            return View(model);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirm(int? ID)
        {
            _Report.Remove(ID);
            return RedirectToAction("Index");
        }
    }
}