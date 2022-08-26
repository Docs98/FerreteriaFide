using FerreteriaFide.Domain.Models;
using FerreteriaFide.Infraestructura.Data;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;

namespace Nazox.Auth
{
    public class AuthLoginController : Controller
    {
        private static IConfiguration config { get; set; }

        private readonly IHttpContextAccessor httpContextAccessor;
        private ISession session => httpContextAccessor.HttpContext.Session;

        private readonly ILogger<AuthLoginController> _logger;

        private readonly ApplicationDbContext _context;

        public AuthLoginController(ILogger<AuthLoginController> logger, IHttpContextAccessor _httpContextAccessor, ApplicationDbContext context, IConfiguration Iconfig)
        {
            _logger = logger;
            httpContextAccessor = _httpContextAccessor;
            _context = context;
            config = Iconfig;
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
                session.SetInt32("IDrol", usuarioValido.roles.IdRol);
                session.SetString("Nombre",usuarioValido.Nombre);
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
