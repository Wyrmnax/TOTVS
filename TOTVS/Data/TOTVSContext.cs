using Microsoft.EntityFrameworkCore;

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

        public DbSet<TOTVS.Models.Pedido> Pedido { get; set; }

        public DbSet<TOTVS.Models.ProdutoPedido> ProdutoPedidos { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<ProdutoPedido>()
                .HasKey(pp => new { pp.PedidoID, pp.ProdutoID });

            modelBuilder.Entity<ProdutoPedido>()
                .HasOne(p => p.Produto)
                .WithMany(pp => pp.ProdutoPedidos)
                .HasForeignKey(p => p.ProdutoID);

            modelBuilder.Entity<ProdutoPedido>()
                .HasOne(p => p.Pedido)
                .WithMany(pp => pp.ProdutoPedidos)
                .HasForeignKey(p => p.PedidoID);
               

        }

    }
}
