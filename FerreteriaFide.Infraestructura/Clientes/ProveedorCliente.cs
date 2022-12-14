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
    public class ProveedorCliente : IProveedores
    {
        ApplicationDbContext _dbContext;
        public ProveedorCliente(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void AddProveedor(Proveedor proveedor)
        {
            _dbContext.proveedor.Add(proveedor);
            _dbContext.SaveChanges();
        }
        public List<Proveedor> GetAllProveedores()
        {
            return _dbContext.proveedor.ToList();
        }

        public Proveedor GetProveedor(int IdProveedor)
        {
            return _dbContext.proveedor.FirstOrDefault(x => x.IdProveedor == IdProveedor);
        }
        public List<Proveedor> GetProveedores()
        {
            return _dbContext.proveedor.Include(x => x.IdProveedor).ToList();
        }
        public void EditProveedor(Proveedor proveedor)
        {
            _dbContext.proveedor.Update(proveedor);
            _dbContext.SaveChanges();
        }

        public void DeleteProveedor(int idproveedor)
        {
            _dbContext.proveedor.Remove(GetProveedor(idproveedor));
            _dbContext.SaveChanges();
        }
    }
}
