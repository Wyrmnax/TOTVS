using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using TOTVS.Models;

namespace TOTVS.SeedData
{
    public class SeedDataProdutos
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new TOTVSContext(
                serviceProvider.GetRequiredService<DbContextOptions<TOTVSContext>>()))
            {
                // Look for any Client.
                if (context.Produto.Any())
                {
                    return;   // DB has been seeded
                }

                context.Produto.AddRange(
                     new Produto
                     {
                         Descricao = "Produto Seeded 1",
                         Valor = 12.51f
                     },

                     new Produto
                     {
                         Descricao = "Produto Seeded 2",
                         Valor = 13.00f
                     },

                     new Produto
                     {
                         Descricao = "Produto Seeded 3",
                         Valor = 15f
                     },

                     new Produto
                     {
                         Descricao = "Produto Seeded 3",
                         Valor = 55.43f
                     },

                     new Produto
                     {
                         Descricao = "Produto Seeded 3",
                         Valor = 7348.99f
                     }
                );
                context.SaveChanges();
            }
        }
    }
}
