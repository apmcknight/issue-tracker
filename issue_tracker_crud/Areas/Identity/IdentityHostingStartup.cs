using System;
using issue_tracker_crud.Areas.Identity.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(issue_tracker_crud.Areas.Identity.IdentityHostingStartup))]
namespace issue_tracker_crud.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<idenityDataContext>(options =>
                    options.UseSqlite(
                        context.Configuration.GetConnectionString("idenityDataContextConnection")));

                services.AddDefaultIdentity<idenityUserClass>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<idenityDataContext>();
            });
        }
    }
}