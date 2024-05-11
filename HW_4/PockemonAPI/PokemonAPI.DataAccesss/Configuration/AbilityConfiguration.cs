using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PokemonAPI.DataAccesss.Entities;

namespace PokemonAPI.DataAccesss.Configuration;

public class AbilityConfiguration: IEntityTypeConfiguration<Ability>
{
    public void Configure(EntityTypeBuilder<Ability> builder)
    {
        builder.HasKey(p => p.Id);
        builder.Property(p => p.Id).ValueGeneratedOnAdd();

        builder.HasMany(c => c.Pockemones)
            .WithMany(p => p.Abilities);
    }
}