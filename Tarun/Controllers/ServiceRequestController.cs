using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tarun.Models;
using Tarun.Services;

namespace Tarun.Controllers
{
    public class ServiceRequestController : Controller
    {

        private readonly IServiceRequest _ServiceRequest;

        public ServiceRequestController (IServiceRequest _IServiceRequest)
        {
            this._ServiceRequest = _IServiceRequest;
        }
        public IActionResult Index()
        {
            return View(_ServiceRequest.GetServiceRequests);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(ServiceRequest model)
        {
            if (ModelState.IsValid)
            {
                _ServiceRequest.Add(model);
            }
            return View(model);

        }
        [HttpGet]
        public IActionResult Delete(int? ID)
        {
            ServiceRequest model = _ServiceRequest.GetServiceRequest(ID);
            return View(model);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirm(int? ID)
        {
            _ServiceRequest.Remove(ID);
            return RedirectToAction("Index");
        }

    }
}