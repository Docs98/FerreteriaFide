using FerreteriaFide.Domain.Models;
using FerreteriaFide.Infraestructura.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ferreteria_Fide.Marca
{
    [Authorize]
    public class MarcaController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MarcaController(ApplicationDbContext context)
        {
            _context = context;
        }
        
        public IActionResult Index()
        {

            List<FerreteriaFide.Domain.Models.Marca> listMarca = new List<FerreteriaFide.Domain.Models.Marca>();
            listMarca = new FerreteriaFide.Infraestructura.Clientes.MarcaCliente(_context).GetAllMarcas();
            return View(listMarca);
        }

        [HttpGet]
        [Authorize(Roles = "Administrator")]
        public IActionResult Edit(int id)
        {
            
            var marca = new FerreteriaFide.Infraestructura.Clientes.MarcaCliente(_context).GetMarca(id);
            
            return View(marca);
        }
        [Authorize(Roles = "Administrator")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Authorize(Roles = "Administrator")]
        public IActionResult Create(FerreteriaFide.Domain.Models.Marca marca)
        {
            if (ModelState.IsValid)
            {
                new FerreteriaFide.Infraestructura.Clientes.MarcaCliente(_context).AddMarca(marca);
                return RedirectToAction("Index", "Marca");
            }
            return RedirectToAction("Create", "Marca");
        }

        [HttpPost]
        [Authorize(Roles = "Administrator")]
        public IActionResult UpdateMarca(FerreteriaFide.Domain.Models.Marca marca)
        {
            if (ModelState.IsValid)
            {
                new FerreteriaFide.Infraestructura.Clientes.MarcaCliente(_context).EditMarca(marca);
                return RedirectToAction("Index", "Marca");
            }
            return RedirectToAction("Edit", "Marca");
        }

        [HttpGet]
        [Authorize(Roles = "Administrator")]
        public IActionResult Delete(int id)
        {
            var marca = new FerreteriaFide.Infraestructura.Clientes.MarcaCliente(_context).GetMarca(id);

            return View(marca);
        }

        [HttpPost]
        [Authorize(Roles = "Administrator")]
        public IActionResult DeleteMarca(int idMarca)
        {
            if (ModelState.IsValid)
            {
                new FerreteriaFide.Infraestructura.Clientes.MarcaCliente(_context).DeleteMarca(idMarca);
                return RedirectToAction("Index", "Marca");
            }
            return RedirectToAction("Index", "RegistrarMarca");
        }

    }
}
