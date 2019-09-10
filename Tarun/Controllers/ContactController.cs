using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tarun.Models;
using Tarun.Services;

namespace Tarun.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContact _Contact;

        public ContactController(IContact _IContact)
        {
            _Contact = _IContact;
        }
        public IActionResult Index()
        {
            return View(_Contact.GetContacts);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Contact model)
        {
            if (ModelState.IsValid)
            {
                _Contact.Add(model);
                return RedirectToAction("Index");
            }
            return View(model);

        }
    }
}