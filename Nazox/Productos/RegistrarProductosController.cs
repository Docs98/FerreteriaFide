using FerreteriaFide.Domain.Models;
using FerreteriaFide.Infraestructura.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ferreteria_Fide.Productos
{
    public class RegistrarProductosController : Controller
    {
        ApplicationDbContext _dbContext;
        public RegistrarProductosController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {

            List<SelectListItem> comboMarcas = new List<SelectListItem>();
            var listaMarcas = new FerreteriaFide.Infraestructura.Clientes.MarcaCliente(_dbContext).GetAllMarcas();
            foreach (var item in listaMarcas)
            {
                comboMarcas.Add(new SelectListItem
                {
                    Text = item.Nombre,
                    Value= item.IdMarca.ToString()
                });
            }
            ViewBag.Marcas = comboMarcas;
            // combo de proveedores
            List<SelectListItem> comboProveedores = new List<SelectListItem>();
            var listaProveedores = new FerreteriaFide.Infraestructura.Clientes.ProveedorCliente(_dbContext).GetAllProveedores();
            foreach (var item in listaProveedores)
            {
                comboProveedores.Add(new SelectListItem
                {
                    Text = item.Nombre,
                    Value = item.IdProveedor.ToString()
                });
            }
            ViewBag.Proveedores = comboProveedores;



            return View();
        }
        public IActionResult agregar(Producto producto)
        {
            new FerreteriaFide.Infraestructura.Clientes.ProductosCliente(_dbContext).AddProducto(producto);
            return View(producto);
        }
    }
}
