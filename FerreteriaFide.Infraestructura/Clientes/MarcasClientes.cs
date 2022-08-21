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
    public class MarcasClientes : IMarca
    {
        ApplicationDbContext _dbContext;
        public MarcasClientes(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Marca GetMarca(int IdMarca)
        {
            throw new NotImplementedException();
        }

        public List<Marca> GetMarca()
        {
            return _dbContext.marca.Include(x => x.Nombre).ToList();
        }
    }
}
