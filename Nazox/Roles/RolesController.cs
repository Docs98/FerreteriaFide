using FerreteriaFide.Domain.Models;
using FerreteriaFide.Infraestructura.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ferreteria_Fide.Roles
{
    [Authorize(Roles = "Administrator")]
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
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var rol = new FerreteriaFide.Infraestructura.Clientes.RolesClientes(_context).GetRoles(id);

            return View(rol);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(FerreteriaFide.Domain.Models.Roles roles)
        {
            if (ModelState.IsValid)
            {
                new FerreteriaFide.Infraestructura.Clientes.RolesClientes(_context).AddRoles(roles);
                return RedirectToAction("Index", "Roles");
            }
            return RedirectToAction("Create", "Roles");
        }

        [HttpPost]
        public IActionResult UpdateRoles(FerreteriaFide.Domain.Models.Roles roles)
        {
            if (ModelState.IsValid)
            {
                new FerreteriaFide.Infraestructura.Clientes.RolesClientes(_context).EditRoles(roles);
                return RedirectToAction("Index", "Roles");
            }
            return RedirectToAction("Create", "Roles");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var roles = new FerreteriaFide.Infraestructura.Clientes.RolesClientes(_context).GetRoles(id);

            return View(roles);
        }

        [HttpPost]
        public IActionResult DeleteRoles(int idRol)
        {
            if (ModelState.IsValid)
            {
                new FerreteriaFide.Infraestructura.Clientes.RolesClientes(_context).DeleteRoles(idRol);
                return RedirectToAction("Index", "Roles");
            }
            return RedirectToAction("Create", "Roles");
        }
    }
}
