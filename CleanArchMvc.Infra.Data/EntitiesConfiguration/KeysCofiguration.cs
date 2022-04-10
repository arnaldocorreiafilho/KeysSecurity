using CleanArchMvc.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanArchMvc.Infra.Data.EntitiesConfiguration
{
    public class KeysCofiguration : IEntityTypeConfiguration<Keys>
    {
        
        public void Configure(EntityTypeBuilder<Keys> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(p => p.Key).HasMaxLength(100).IsRequired();
            builder.Property(p => p.Value).HasMaxLength(300).IsRequired();
            builder.Property(p => p.Hash).HasMaxLength(300).IsRequired();
        }
    }
}
