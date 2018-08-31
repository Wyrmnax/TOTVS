using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using TOTVS.Models;

namespace TOTVS.SeedData
{
    public static class SeedDataClientes
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new TOTVSContext(
                serviceProvider.GetRequiredService<DbContextOptions<TOTVSContext>>()))
            {
                // Look for any Client.
                if (context.Cliente.Any())
                {
                    return;   // DB has been seeded
                }

                context.Cliente.AddRange(
                     new Cliente
                     {
                         Nome = "Cliente Generico",
                         CPF = "23340128073"
                     }
                );
                context.SaveChanges();
            }
        }
    }
}