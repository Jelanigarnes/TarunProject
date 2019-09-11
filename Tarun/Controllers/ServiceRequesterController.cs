using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarun.Models;
using Tarun.Services;
using Microsoft.AspNetCore.Mvc;

namespace Tarun.Controllers
{
    public class ServiceRequesterController : Controller
    {
        private readonly IServiceRequester _ServiceRequester;
        public ServiceRequesterController(IServiceRequester _IServiceRequester)
        {
             _ServiceRequester= _IServiceRequester;
        }
        public IActionResult Index()
        {
            return View(_ServiceRequester.GetServiceRequesters);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(ServiceRequester model)
        {
            if (ModelState.IsValid)
            {
                _ServiceRequester.Add(model);
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult Delete(int? ID)
        {
            ServiceRequester model = _ServiceRequester.GetServiceRequester(ID);
            return View(model);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirm(int? ID)
        {
            _ServiceRequester.Remove(ID);
            return RedirectToAction("Index");
        }
    }
}