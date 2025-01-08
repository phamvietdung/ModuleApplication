using ShareModuleCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

var modules = builder.Services.LoadModules();

foreach (var module in modules)
{
    module.ConfigureServices(builder.Services);
}

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

var app = builder.Build();

var env = app.Environment;

// Configure the HTTP request pipeline.

app.UseRouting();

app.UseAuthorization();

foreach (var module in modules)
{
    module.Configure(app, env);
}

//app.MapControllers();


app.UseSwagger();

app.UseSwaggerUI();


app.Run();
