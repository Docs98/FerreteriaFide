using System;
using Ferreteria_Fide.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(Ferreteria_Fide.Areas.Identity.IdentityHostingStartup))]
namespace Ferreteria_Fide.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<Ferreteria_FideContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("Ferreteria_FideContextConnection")));

                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<Ferreteria_FideContext>();
            });
        }
    }
}
