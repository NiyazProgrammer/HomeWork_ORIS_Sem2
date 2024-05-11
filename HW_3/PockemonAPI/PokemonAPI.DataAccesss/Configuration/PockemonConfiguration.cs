using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PokemonAPI.DataAccesss.Entities;

namespace PokemonAPI.DataAccesss.Configuration;

public class PockemonConfiguration: IEntityTypeConfiguration<Pokemon>
{
    public void Configure(EntityTypeBuilder<Pokemon> builder)
    {
        builder.HasKey(p => p.Id);
        builder.Property(p => p.Id).ValueGeneratedOnAdd();

        builder.HasOne(p => p.Breeding)
            .WithOne(b => b.Pockemon);

        builder.HasMany(p => p.Abilities)
            .WithMany(a => a.Pockemones);

        builder.HasMany(p => p.Moves)
            .WithMany(m => m.Pockemons);
        
        builder.HasMany(p => p.PokemonTypes)
            .WithMany(t => t.Pockemones);
    }
}