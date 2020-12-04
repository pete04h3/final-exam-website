using System;
using FinalsystemPrototype2.iteration.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(FinalsystemPrototype2.iteration.Areas.Identity.IdentityHostingStartup))]
namespace FinalsystemPrototype2.iteration.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<FinalsystemPrototype2iterationContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("FinalsystemPrototype2iterationContextConnection")));

                //services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                //    .AddEntityFrameworkStores<FinalsystemPrototype2iterationContext>();
            });
        }
    }
}