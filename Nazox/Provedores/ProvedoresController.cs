using FerreteriaFide.Domain.Models;
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

            List<Proveedor> listprov = new List<Proveedor>();
            listprov = new FerreteriaFide.Infraestructura.Clientes.ProveedorCliente(_context).GetAllProveedores();
            return View(listprov);
        }
    }
}
