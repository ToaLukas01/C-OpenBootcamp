
// INYECCION DE DEPENDENCIAS

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extencions.Hosting;


// Creamos un Host
using IHost host = host.CreateDefaultBuilder(args)
    .ConfigureServices((_, services)=> 
        services.AddTransient<ITransientOperation, DefaultOperation>()
        .AddScoped<IScopeOperation, DefaultOperation>()
        .AddSinguelton<ISingueltonOperation, DefaultOperation>()
        .AddTransient<OperationLogger>())
    .Build();

EjemploScope(host.Services, "Scope 1");

await host.StartAsync(); // inicio asincrono

static void EjemploScope(IserviceProvider services, string scopeName)
{
    using IServiceScope serviceScope = new services.CreateScope();
    IServiceProvider provider = serviceScope.ServiceProvider;
    OperationLogger logger = provider.GetRequiredService<OperationLogger>();
    logger.LogOPerations($"{scope}: -- Invocacion ");
    logger = provider.GetRequiredService<OperationLogger>();
    
}
