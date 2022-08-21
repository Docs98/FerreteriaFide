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
    public class RolesClientes : IRoles
    {
        ApplicationDbContext _dbContext;
        public RolesClientes(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<Roles> GetAllRoles()
        {
            return _dbContext.roles.ToList();
        }

        public Roles GetRoles(int IdRol)
        {
            return _dbContext.roles.FirstOrDefault(x => x.IdRol == IdRol);
        }
    }
}
