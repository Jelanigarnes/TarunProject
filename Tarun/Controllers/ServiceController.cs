using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarun.Models;
using Tarun.Services;
using Microsoft.AspNetCore.Mvc;

namespace Tarun.Controllers
{
    public class ServiceController : Controller
    {
        private readonly IService _Service;

        public ServiceController(IService _Iservice)
        {
            _Service = _Iservice;
        }
        public IActionResult Index()
        {
            return View(_Service.GetServices);
        }
        [HttpGet]
        public IActionResult Create()
        {
            Service model = new Service();
            model.ServiceID = 0;
            return View(model);
        }
        [HttpPost]
        public IActionResult Create(Service model)
        {
            if (ModelState.IsValid)
            {

                _Service.Add(model);
                return RedirectToAction("Index");
            }
            return View();

        }
        [HttpGet]
        public IActionResult Delete(int? ID)
        {
            if (ID == null)
            {
                return NotFound();

            }
            else
            {
                Service model = _Service.GetService(ID);
                return View(model);
            }
           
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirm(int? ID)
        {
            _Service.Remove(ID);
            return RedirectToAction("Index");
        }
        public IActionResult Details(int? ID)
        {
            return View(_Service.GetService(ID));
        }
        public IActionResult Edit(int? ID)
        {
            var model = _Service.GetService(ID);
            return View("Create", model);
        }


    }
}