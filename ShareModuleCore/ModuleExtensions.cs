using System.Reflection;

namespace ShareModuleCore
{
    public static class ModuleExtensions
    {
        public static IEnumerable<IMoodule> LoadModules(this IServiceCollection services)
        {
            var modules = new List<IMoodule>();

            var modulePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory);

            var _ = services.AddControllers();

            if (Directory.Exists(modulePath))
            {
                foreach (var dll in Directory.GetFiles(modulePath, "*ManagementModule.dll"))
                {
                    var assembly = Assembly.LoadFrom(dll);
                    var moduleTypes = assembly.GetTypes()
                        .Where(t => typeof(IMoodule).IsAssignableFrom(t) && !t.IsAbstract);

                    foreach (var type in moduleTypes)
                    {
                        var module = (IMoodule)Activator.CreateInstance(type);
                        modules.Add(module);
                    }

                    _.AddApplicationPart(assembly);
                }
            }

            return modules;
        }
    
    }
}
