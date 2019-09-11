using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tarun.Services;
using Tarun.Models;

namespace Tarun.Controllers
{
    public class Service_ProviderController : Controller
    {
        private readonly IService_Provider _ServiceProvider;
        public Service_ProviderController(IService_Provider _IserviceProvider)
        {
            _ServiceProvider = _IserviceProvider;
        }

        public IActionResult Index()
        {
            return View(_ServiceProvider.GetService_Providers);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Service_Provider model)
        {
            if (ModelState.IsValid)
            {
                _ServiceProvider.Add(model);
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult Delete(int? ID)
        {
            Service_Provider model = _ServiceProvider.GetService_Provider(ID);
            return View(model);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirm(int? ID)
        {
            _ServiceProvider.Remove(ID);
            return RedirectToAction("Index");
        }


    }
}