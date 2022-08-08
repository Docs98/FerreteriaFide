using FerreteriaFide.Aplicacion.Data;
using FerreteriaFide.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerreteriaFide.Infraestructura.Data
{
    public class ApplicationDbContext: DbContext, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
             : base(options) { }

        public DbSet<Producto> productos { get; set; }
        public DbSet<Usuarios> usuarios { get; set; }
        public DbSet<Roles> roles { get; set; }
        public DbSet<Marca> marca { get; set; }
        public DbSet<Proveedor> proveedor { get; set; }
    }
}
