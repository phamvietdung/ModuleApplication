using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using ShareModuleCore;
using UserManagementModule.Interfaces;
using UserManagementModule.Services;

namespace UserManagementModule
{
    public class UserManagementModule : IMoodule
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IUserServices, UserServices>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

        }

    }
}