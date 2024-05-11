using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PokemonAPI.DataAccesss.Entities;

namespace PokemonAPI.DataAccesss.Configuration;

public class PockemonTypeConfiguration: IEntityTypeConfiguration<PockemonType>
{
    public void Configure(EntityTypeBuilder<PockemonType> builder)
    {
        builder.HasKey(p => p.Id);
        builder.Property(p => p.Id).ValueGeneratedOnAdd();

        builder.HasMany(t => t.Pockemones)
            .WithMany(p => p.PokemonTypes);
    }
}