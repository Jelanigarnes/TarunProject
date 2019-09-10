using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tarun.Models;
using Tarun.Services;

namespace Tarun.Controllers
{
    public class AdminController : Controller
    {
        private readonly IAdmin _Admin;

        public AdminController(IAdmin _IAdmin)
        {
            _Admin = _IAdmin;
        }
        public IActionResult Index()
        {
            return View(_Admin.GetAdmins);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Admin model)
        {
            if (ModelState.IsValid)
            {
                _Admin.Add(model);
                return RedirectToAction("Index");
            }
            return View(model);

        }
    }
}