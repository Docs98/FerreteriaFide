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
    public class UsuariosCliente : IUsuarios
    {
        ApplicationDbContext _dbContext;
        public UsuariosCliente(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Usuarios> GetAllUsuarios()
        {
            return _dbContext.usuarios.ToList();
        }

        public Usuarios GetUsuarios(int Cedula)
        {
            return _dbContext.usuarios.FirstOrDefault(x => x.Cedula == Cedula);
        }

        public List<Usuarios> GetUsuarios()
        {
            return _dbContext.usuarios.Include(x => x.Cedula).ToList();
        }

        public void AddUsuario(Usuarios usuario)
        {
            try
            {
                _dbContext.usuarios.Add(usuario);
                _dbContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Usuarios? IsValidUsuario(Usuarios usuario)
        {
            if (usuario!=null)
            {
#pragma warning disable CS8603 // Possible null reference return.
                return _dbContext.usuarios.Include(x => x.roles).FirstOrDefault(x => x.Email == usuario.Email && x.Clave == usuario.Clave);
#pragma warning restore CS8603 // Possible null reference return.
            }
            return null;
        }
    }
}
