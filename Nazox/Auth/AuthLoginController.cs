using FerreteriaFide.Domain.Models;
using FerreteriaFide.Infraestructura.Data;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Nazox.Auth
{
    public class AuthLoginController : Controller
    {

        private readonly ApplicationDbContext _context;

        public AuthLoginController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> SigninAsync(Usuarios usuario)
        {
            var usuarioValido = new FerreteriaFide.Infraestructura.Clientes.UsuariosCliente(_context).IsValidUsuario(usuario);
            if (usuarioValido != null)
            {
                var claims =
                        new[]
                        {
                            new Claim("UserId",usuarioValido.Nombre),
                            new Claim("Email", usuarioValido.Email),
                            new Claim(ClaimTypes.Role, usuarioValido.roles.IdRol.ToString())
                        };

                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));

                return RedirectToAction("Index", "Productos");
            }
            return RedirectToAction("Index", "AuthLogin");
        }

        public async Task<IActionResult> Logoff()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "AuthLogin");
        }


    }
}
