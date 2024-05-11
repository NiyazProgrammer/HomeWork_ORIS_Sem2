using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PokemonAPI.DataAccesss.Entities;

namespace PokemonAPI.DataAccesss.Configuration;

public class MoveConfiguration: IEntityTypeConfiguration<Move>
{
    public void Configure(EntityTypeBuilder<Move> builder)
    {
        builder.HasKey(p => p.Id);
        builder.Property(p => p.Id).ValueGeneratedOnAdd();

        builder.HasMany(m => m.Pockemons)
            .WithMany(p => p.Moves);
    }
}