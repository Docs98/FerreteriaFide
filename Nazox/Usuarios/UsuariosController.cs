using FerreteriaFide.Infraestructura.Data;
using FerreteriaFide.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using UsuarioModel = FerreteriaFide.Domain.Models.Usuarios;
using RolesModel = FerreteriaFide.Domain.Models.Roles;
using FerreteriaFide.Aplicacion.Contratos;

namespace Ferreteria_Fide.Usuarios
{
    [Authorize(Roles = "1")]
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
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var usuarios = new FerreteriaFide.Infraestructura.Clientes.UsuariosCliente(_context).GetUsuarios(id);

            return View(usuarios);
        }
        [HttpPost]
        public IActionResult UpdateUsuarios(UsuarioModel usuarios, RolesModel roles)
        {
            usuarios.roles = new FerreteriaFide.Infraestructura.Clientes.RolesClientes(_context).GetRoles(roles.IdRol);

            if (usuarios.roles != null && usuarios.Cedula != null && usuarios.Clave != null)
            {
                new FerreteriaFide.Infraestructura.Clientes.UsuariosCliente(_context).EditUsuarios(usuarios);
                return RedirectToAction("Index", "Usuarios");
            }
            return RedirectToAction("Index", "Usuarios");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var usuarios = new FerreteriaFide.Infraestructura.Clientes.UsuariosCliente(_context).GetUsuarios(id);

            return View(usuarios);
        }

        [HttpPost]
        public IActionResult DeleteUsuarios(int cedula)
        {
            if (ModelState.IsValid)
            {
                new FerreteriaFide.Infraestructura.Clientes.UsuariosCliente(_context).DeleteUsuarios(cedula);
                return RedirectToAction("Index", "Usuarios");
            }
            return RedirectToAction("Index", "Usuarios");
        }
    }
}
