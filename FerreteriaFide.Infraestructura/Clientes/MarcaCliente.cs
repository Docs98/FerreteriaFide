using FerreteriaFide.Aplicacion.Contratos;
using FerreteriaFide.Domain.Models;
using FerreteriaFide.Infraestructura.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerreteriaFide.Infraestructura.Clientes
{
    public class MarcaCliente : IMarca
    {
        ApplicationDbContext _dbContext;
        public MarcaCliente(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<Marca> GetAllMarcas()
        {
            return _dbContext.marca.ToList();
        }

        public void AddMarca(Marca marca)
        {
            _dbContext.marca.Add(marca);
            _dbContext.SaveChanges();
        }

        public Marca GetMarca(int IdMarca)
        {
            return _dbContext.marca.FirstOrDefault(x => x.IdMarca == IdMarca);
        }

        public void EditMarca(Marca marca)
        {
            _dbContext.marca.Update(marca);
            _dbContext.SaveChanges();
        }

        public void DeleteMarca(int idmarca)
        {
            _dbContext.marca.Remove(GetMarca(idmarca));
            _dbContext.SaveChanges();
        }
    }
}
