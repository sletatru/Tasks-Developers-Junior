using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Task_web.Controllers
{
    public class DocsController : Controller
    {
        public IActionResult Index()
        {
            return Redirect("swagger");
        }
    }
}