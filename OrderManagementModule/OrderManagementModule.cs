using OrderManagementModule.Interfaces;
using OrderManagementModule.Servies;
using ShareModuleCore;

namespace OrderManagementModule
{
    public class OrderManagementModule : IMoodule
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IOrderServices, OrderServices>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

        }
    }
}
