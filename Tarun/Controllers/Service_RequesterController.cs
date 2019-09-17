using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarun.Models;
using Tarun.Services;
using Microsoft.AspNetCore.Mvc;

namespace Tarun.Controllers
{
    public class Service_RequesterController : Controller
    {
        private readonly IService_Requester _Service_Requester;
        public Service_RequesterController(IService_Requester _IService_Requester)
        {
             _Service_Requester= _IService_Requester;
        }
        public IActionResult Index()
        {
            return View(_Service_Requester.GetService_Requesters);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Service_Requester model)
        {
            if (ModelState.IsValid)
            {
                _Service_Requester.Add(model);
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult Delete(int? ID)
        {
            Service_Requester model = _Service_Requester.GetService_Requester(ID);
            return View(model);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirm(int? ID)
        {
            _Service_Requester.Remove(ID);
            return RedirectToAction("Index");
        }
    }
}