using FerreteriaFide.Domain.Models;
using FerreteriaFide.Infraestructura.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ferreteria_Fide.Marcas
{
    public class MarcasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MarcasController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

            List<FerreteriaFide.Domain.Models.Marca> listMarca = new List<FerreteriaFide.Domain.Models.Marca>();
            listMarca = new FerreteriaFide.Infraestructura.Clientes.MarcaCliente(_context).GetAllMarcas();
            return View(listMarca);
        }
    }
}
