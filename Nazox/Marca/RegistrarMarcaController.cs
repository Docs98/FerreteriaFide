using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FerreteriaFide.Domain.Models;
using Microsoft.EntityFrameworkCore;
using FerreteriaFide.Infraestructura.Data;

namespace Ferreteria_Fide.Marca
{
    public class RegistrarMarcaController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RegistrarMarcaController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create(FerreteriaFide.Domain.Models.Marca marca)
        {
            if (ModelState.IsValid)
            {
                new FerreteriaFide.Infraestructura.Clientes.MarcaCliente(_context).AddMarca(marca);
                return RedirectToAction("Index", "Marca");
            }
            return RedirectToAction("Index", "RegistrarMarca");
        }
        
    }
}
