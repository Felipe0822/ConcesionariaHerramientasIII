using ConcesionarioHerramientas.Models;
using ConcesionarioHerramientas.Views;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace ConcesionarioHerramientas
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            var services = new ServiceCollection();


            services.AddDbContext<ConexionDB>(options =>
               options.UseSqlServer("Server=FELIPE\\SQLEXPRESS;Database=ConcesionarioDB;Trusted_Connection=True;TrustServerCertificate=True;"));

            var serviceProvider = services.BuildServiceProvider();

            ApplicationConfiguration.Initialize();

            var dbContext = serviceProvider.GetRequiredService<ConexionDB>();

            Application.Run(new frmMenu());
        }
    }
}