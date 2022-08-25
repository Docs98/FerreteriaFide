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
    public class RolesClientes : IRoles
    {
        ApplicationDbContext _dbContext;
        public RolesClientes(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void AddRoles(Roles roles)
        {
            _dbContext.roles.Add(roles);
            _dbContext.SaveChanges();
        }
        public List<Roles> GetAllRoles()
        {
            return _dbContext.roles.ToList();
        }

        public Roles GetRoles(int IdRol)
        {
            return _dbContext.roles.FirstOrDefault(x => x.IdRol == IdRol);
        }
        public List<Roles> GetRoles()
        {
            return _dbContext.roles.Include(x => x.IdRol).ToList();
        }
        public void EditRoles(Roles roles)
        {
            _dbContext.roles.Update(roles);
            _dbContext.SaveChanges();
        }

        public void DeleteRoles(int idRol)
        {
            _dbContext.roles.Remove(GetRoles(idRol));
            _dbContext.SaveChanges();
        }
    }
}
