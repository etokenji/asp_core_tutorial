using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace asp_core_tutorial.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome(string name, int numTime = 1)
        {
            var inputName = "Default";

            if (!string.IsNullOrEmpty(name))
            {
                // javascript対策
                inputName = HtmlEncoder.Default.Encode(name);
            }

            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTime;

            return View();

            //return $"Hello {inputName}, NumTimes is: {numTime}";
        }
    }
}