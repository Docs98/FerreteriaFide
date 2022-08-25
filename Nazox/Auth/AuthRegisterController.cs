using FerreteriaFide.Domain.Models;
using FerreteriaFide.Infraestructura.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nazox.Auth
{
    public class AuthRegisterController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AuthRegisterController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(Usuarios usuario)
        {
            if (usuario.roles == null)
            {
                usuario.roles = new FerreteriaFide.Infraestructura.Clientes.RolesClientes(_context).GetRoles(3);
                new FerreteriaFide.Infraestructura.Clientes.UsuariosCliente(_context).AddUsuario(usuario);
                return RedirectToAction("Index", "AuthLogin");
            }

            return View("Index");
        }
    }
}
