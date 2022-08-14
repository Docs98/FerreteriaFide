using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ferreteria_Fide.Productos
{
    public class RegistrarProductosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
