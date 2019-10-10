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
        private readonly IService _Service;
        private readonly IService_Requester _Service_Requester;

        public ServiceRequestController (IServiceRequest _IServiceRequest, IService _IService, IService_Requester _IService_Requester)
        {
            _ServiceRequest = _IServiceRequest;
            _Service = _IService;
            _Service_Requester = _IService_Requester;
        }
        public IActionResult Index()
        {
            return View(_ServiceRequest.GetServiceRequests);
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Service_Requesters = _Service_Requester.GetService_Requesters;
            ViewBag.Services = _Service.GetServices;
            
            return View();
        }
        [HttpPost]
        public IActionResult Create(ServiceRequest model)
        {
            if (ModelState.IsValid)
            {
                _ServiceRequest.Add(model);
                return RedirectToAction("Index");
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