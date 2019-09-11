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
        [HttpGet]
        public IActionResult Delete(int? ID)
        {
            Admin model = _Admin.GetAdmin(ID);
            return View(model);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirm(int? ID)
        {
            _Admin.Remove(ID);
            return RedirectToAction("Index");
        }
    }
}