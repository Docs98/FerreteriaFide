using FerreteriaFide.Aplicacion.Contratos;
using FerreteriaFide.Domain.Models;
using FerreteriaFide.Infraestructura.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerreteriaFide.Infraestructura.Clientes
{
    public class ProductosCliente : IProducto
    {
        ApplicationDbContext _dbContext;
        public ProductosCliente(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void AddProducto(Producto producto)
        {
            _dbContext.productos.Add(producto);
            _dbContext.SaveChanges();
        }

        public Producto GetProducto(int IdProducto)
        {
            return _dbContext.productos.FirstOrDefault(x => x.IdProducto == IdProducto);
        }

        public List<Producto> GetProductos()
        {
            return _dbContext.productos.Include(x => x.marca).ToList();
        }
    }
}
