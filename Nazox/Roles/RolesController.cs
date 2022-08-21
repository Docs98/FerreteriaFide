using FerreteriaFide.Infraestructura.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ferreteria_Fide.Roles
{

    public class RolesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RolesController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<FerreteriaFide.Domain.Models.Roles> listprov = new List<FerreteriaFide.Domain.Models.Roles>();
            listprov = new FerreteriaFide.Infraestructura.Clientes.RolesClientes(_context).GetAllRoles();
            return View(listprov);
        }
    }
}
