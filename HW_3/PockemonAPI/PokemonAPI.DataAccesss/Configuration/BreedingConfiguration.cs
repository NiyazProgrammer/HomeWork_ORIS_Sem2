using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PokemonAPI.DataAccesss.Entities;

namespace PokemonAPI.DataAccesss.Configuration;

public class BreedingConfiguration: IEntityTypeConfiguration<Breeding>
{
    public void Configure(EntityTypeBuilder<Breeding> builder)
    {
        builder.HasKey(p => p.Id);
        builder.Property(p => p.Id).ValueGeneratedOnAdd();

        builder.HasOne(b => b.Pockemon)
            .WithOne(p => p.Breeding);
    }
}