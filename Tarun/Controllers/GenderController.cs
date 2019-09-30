using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tarun.Models;
using Tarun.Services;

namespace Tarun.Controllers
{
    public class GenderController : Controller
    {
        private readonly IGender _Gender;

        public GenderController(IGender _IGender)
        {
            _Gender = _IGender;
        }
        public IActionResult Index()
        {
            return View(_Gender.GetGenders);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Gender model)
        {
            if (ModelState.IsValid)
            {
                _Gender.Add(model);
                return RedirectToAction("Index");
            }
            return View(model);

        }
        [HttpGet]
        public IActionResult Delete(int? ID)
        {
            Gender model = _Gender.GetGender(ID);
            return View(model);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirm(int? ID)
        {
            _Gender.Remove(ID);
            return RedirectToAction("Index");
        }
    }
}