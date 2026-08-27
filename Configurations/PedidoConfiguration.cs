using AulaBackend_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AulaBackend_API.Configurations
{
    public class PedidoConfiguration : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.HasKey(p => p.Id);

            builder
                .HasOne(p => p.Cliente)
                .WithMany()
                .HasForeignKey(p => p.Id);

            builder
                .HasOne(p => p.Produto)
                .WithMany()
                .HasForeignKey(p => p.Id);
        }
    }
}
