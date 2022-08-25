using FerreteriaFide.Aplicacion.Contratos;
using FerreteriaFide.Domain.Models;
using FerreteriaFide.Infraestructura.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MarcaModel = FerreteriaFide.Domain.Models.Marca;

namespace Ferreteria_Fide.Productos
{

    public class ProductosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductosController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

            List<Producto> listprod = new List<Producto>();
            listprod = new FerreteriaFide.Infraestructura.Clientes.ProductosCliente(_context).GetProductos();
            return View(listprod);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var producto = new FerreteriaFide.Infraestructura.Clientes.ProductosCliente(_context).GetProducto(id);
            List<SelectListItem> comboMarcas = new List<SelectListItem>();
            var listaMarcas = new FerreteriaFide.Infraestructura.Clientes.MarcaCliente(_context).GetAllMarcas();
            foreach (var item in listaMarcas)
            {
                comboMarcas.Add(new SelectListItem
                {
                    Text = item.Nombre,
                    Value = item.IdMarca.ToString()
                });
            }
            ViewBag.Marcas = comboMarcas;
            // combo de proveedores
            List<SelectListItem> comboProveedores = new List<SelectListItem>();
            var listaProveedores = new FerreteriaFide.Infraestructura.Clientes.ProveedorCliente(_context).GetAllProveedores();
            foreach (var item in listaProveedores)
            {
                comboProveedores.Add(new SelectListItem
                {
                    Text = item.Nombre,
                    Value = item.IdProveedor.ToString()
                });
            }
            ViewBag.Proveedores = comboProveedores;

            return View(producto);
        }
       
        public IActionResult Create()
        {
            List<SelectListItem> comboMarcas = new List<SelectListItem>();
            var listaMarcas = new FerreteriaFide.Infraestructura.Clientes.MarcaCliente(_context).GetAllMarcas();
            foreach (var item in listaMarcas)
            {
                comboMarcas.Add(new SelectListItem
                {
                    Text = item.Nombre,
                    Value = item.IdMarca.ToString()
                });
            }
            ViewBag.Marcas = comboMarcas;
            // combo de proveedores
            List<SelectListItem> comboProveedores = new List<SelectListItem>();
            var listaProveedores = new FerreteriaFide.Infraestructura.Clientes.ProveedorCliente(_context).GetAllProveedores();
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

        [HttpPost]
        public IActionResult Create(Producto producto,MarcaModel marca,Proveedor proveedor)
        {
            producto.marca = new FerreteriaFide.Infraestructura.Clientes.MarcaCliente(_context).GetMarca(marca.IdMarca);
            producto.proveedor = new FerreteriaFide.Infraestructura.Clientes.ProveedorCliente(_context).GetProveedor(proveedor.IdProveedor);
            if (producto.marca != null && producto.proveedor != null)
            {
                new FerreteriaFide.Infraestructura.Clientes.ProductosCliente(_context).AddProducto(producto);
                return RedirectToAction("Index", "Productos");
            }
            return RedirectToAction("Create", "Productos");
        }

        [HttpPost]
        public IActionResult UpdateProducto(Producto producto, MarcaModel marca, Proveedor proveedor)
        {
            producto.marca = new FerreteriaFide.Infraestructura.Clientes.MarcaCliente(_context).GetMarca(marca.IdMarca);
            producto.proveedor = new FerreteriaFide.Infraestructura.Clientes.ProveedorCliente(_context).GetProveedor(proveedor.IdProveedor);
            if (producto.marca != null && producto.proveedor != null)
            {
                new FerreteriaFide.Infraestructura.Clientes.ProductosCliente(_context).EditProducto(producto);
                return RedirectToAction("Index", "Productos");
            }
            return RedirectToAction("Create", "Productos");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var producto = new FerreteriaFide.Infraestructura.Clientes.ProductosCliente(_context).GetProducto(id);

            return View(producto);
        }

        [HttpPost]
        public IActionResult DeleteProducto(int idProducto)
        {
            if (ModelState.IsValid)
            {
                new FerreteriaFide.Infraestructura.Clientes.ProductosCliente(_context).DeleteProducto(idProducto);
                return RedirectToAction("Index", "Productos");
            }
            return RedirectToAction("Create", "Productos");
        }
    }
}
