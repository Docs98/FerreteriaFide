using Microsoft.AspNetCore.Mvc;
using FerreteriaFide.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ferreteria_Fide.Provedores
{
    public class RegistrarProvedoresController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
    
}
