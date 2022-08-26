using FerreteriaFide.Infraestructura.Data;
using FerreteriaFide.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace Ferreteria_Fide.Usuarios
{
    [Authorize(Roles = "Administrator")]
    public class UsuariosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UsuariosController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List< FerreteriaFide.Domain.Models.Usuarios > listprov = new List<FerreteriaFide.Domain.Models.Usuarios>();
            listprov = new FerreteriaFide.Infraestructura.Clientes.UsuariosCliente(_context).GetAllUsuarios();
            return View(listprov);
        }
    }
}
