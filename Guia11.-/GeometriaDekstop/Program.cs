using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using GeometriaModels.DALs;
using GeometriaDekstop;
using GeometriaModels.Service;

//host es el contenedor principal de la aplicaci�n.
var host = Host.CreateDefaultBuilder().ConfigureServices((context, services) =>
{
    #region Registro de DALs
    services.AddSingleton<IFigurasDAL,FigurasListDAL>();
    #endregion

    #region Registro de services.
    services.AddSingleton<FiguraService>();
    #endregion


    #region Registro de las vistas
    services.AddTransient<Form1>();
    #endregion
})
.Build();

ApplicationConfiguration.Initialize();
var form = host.Services.GetRequiredService<Form1>();
Application.Run(form);

