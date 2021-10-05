using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminLTE_Template.Controllers
{
    public class ErrorController : Controller
    {

        public IActionResult InternalServerError() => View();
        
        public IActionResult NotFound => View();
    }
}
