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
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var proveedor = new FerreteriaFide.Infraestructura.Clientes.ProveedorCliente(_context).GetProveedor(id);

            return View(proveedor);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Proveedor provedor)
        {
            if (ModelState.IsValid)
            {
                new FerreteriaFide.Infraestructura.Clientes.ProveedorCliente(_context).AddProveedor(provedor);
                return RedirectToAction("Index", "Provedores");
            }
            return RedirectToAction("Create", "Provedores");
        }

        [HttpPost]
        public IActionResult UpdateProvedor(Proveedor provedor)
        {
            if (ModelState.IsValid)
            {
                new FerreteriaFide.Infraestructura.Clientes.ProveedorCliente(_context).EditProveedor(provedor);
                return RedirectToAction("Index", "Provedores");
            }
            return RedirectToAction("Create", "Provedores");
        }

            [HttpGet]
        public IActionResult Delete(int id)
        {
            var proveedor = new FerreteriaFide.Infraestructura.Clientes.ProveedorCliente(_context).GetProveedor(id);

            return View(proveedor);
        }

        [HttpPost]
        public IActionResult DeleteProveedor(int idProveedor)
        {
            if (ModelState.IsValid)
            {
                new FerreteriaFide.Infraestructura.Clientes.ProveedorCliente(_context).DeleteProveedor(idProveedor);
                return RedirectToAction("Index", "Provedores");
            }
            return RedirectToAction("Create", "Provedores");
        }

    }
}

