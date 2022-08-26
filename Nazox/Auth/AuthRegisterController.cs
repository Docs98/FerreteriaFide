using FerreteriaFide.Aplicacion.Contratos;
using FerreteriaFide.Domain.Models;
using FerreteriaFide.Infraestructura.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nazox.Auth
{
    public class AuthRegisterController : Controller
    {
        private readonly ApplicationDbContext _context;
        ICartero cartero { get; }
        public AuthRegisterController(ApplicationDbContext context, ICartero cartero)
        {
            _context = context;
            this.cartero = cartero;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(Usuarios usuario)
        {
            if (usuario.roles == null)
            {
                
                usuario.roles = new FerreteriaFide.Infraestructura.Clientes.RolesClientes(_context).GetRoles(3);
                if (new FerreteriaFide.Infraestructura.Clientes.UsuariosCliente(_context).AddUsuario(usuario))
                {
                CorreoElectronico correo =
                new CorreoElectronico
                {
                    Destinatario = usuario.Email,
                    Asunto = "Bienvenido a Ferreteria Fide",
                    Cuerpo = "Bienvenido " + usuario.Nombre + " usted ha creado una cuenta en Ferreteria Fide"
                };
                    try
                    {
                        cartero.Enviar(correo);
                    }
                    catch (Exception ex)
                    {
                        return View("Index");
                    }
                }

                return RedirectToAction("Index", "AuthLogin");
            }

            return View("Index");
        }
    }
}
