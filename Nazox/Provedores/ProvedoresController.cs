using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Ferreteria_Fide.Provedores
{
    public class ProvedoresController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
