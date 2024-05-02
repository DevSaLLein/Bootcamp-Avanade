using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyFirstAPI.models;

namespace MyFirstAPI.Context.Map
{
    public class ContatoMap : IEntityTypeConfiguration<ContatoModel>
    {
        public void Configure(EntityTypeBuilder<ContatoModel> builder)
        {
            builder.HasKey(entity => entity.Id);
            builder.Property(entity => entity.Nome).IsRequired().HasMaxLength(255);
            builder.Property(entity => entity.Telefone).IsRequired().HasMaxLength(255);
        }
    }
}