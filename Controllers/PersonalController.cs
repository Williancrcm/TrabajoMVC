using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using papas.Models;

namespace papas.Controllers
{
    public class PersonalController : Controller
    {
        public IActionResult Index()
    {
        Personal personal = new Personal();
        personal.name = "Willian";
        personal.lastname = "Carcamo";
        personal.age = 19;
        personal.mail = "williamc4@gmail.com";
        personal.number =70803260;
        personal.address = "Morazan, sociedad, barrio el centro";

        return View(personal);
    }
    
    }
}