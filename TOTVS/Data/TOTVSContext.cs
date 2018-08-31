using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TOTVS.Models;

namespace TOTVS.Models
{
    public class TOTVSContext : DbContext
    {
        public TOTVSContext (DbContextOptions<TOTVSContext> options)
            : base(options)
        {
        }

        public DbSet<TOTVS.Models.Cliente> Cliente { get; set; }

        public DbSet<TOTVS.Models.Produto> Produto { get; set; }
    }
}
