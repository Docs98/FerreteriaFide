using FerreteriaFide.Infraestructura.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Ferreteria_Fide.Provedores
{

    public class ProvedoresController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProvedoresController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
