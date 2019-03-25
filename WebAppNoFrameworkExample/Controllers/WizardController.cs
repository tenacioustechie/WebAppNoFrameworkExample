using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAppNoFrameworkExample.Models;

namespace WebAppNoFrameworkExample.Controllers
{
    public class WizardController : Controller
    {
        public IActionResult Index()
        {
            var model = new WizardViewModel() { Step = WizardViewModel.Step1 };
            return View("Wizard", model);
        }

        public IActionResult Step1()
        {
            var model = new WizardViewModel() { Step = WizardViewModel.Step1 };
            return View("Wizard", model);
        }

        public IActionResult Step2()
        {
            var model = new WizardViewModel() { Step = WizardViewModel.Step2 };
            return View("Wizard", model);
        }

        public IActionResult WizardStep1()
        {
            return PartialView("_WizardStep1");
        }

        //[HttpPost]
        //public IActionResult WizardStep1Post()
        //{
        //    var model = new WizardViewModel {
        //        Step1 = new Step1ViewModel()
        //    };
        //    if (!ModelState.IsValid) {
        //        return View("_WizardStep1", model);
        //    }
        //    return View("_WizardStep2", model);
        //}

        public IActionResult WizardStep2()
        {
            return PartialView("_WizardStep2");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}