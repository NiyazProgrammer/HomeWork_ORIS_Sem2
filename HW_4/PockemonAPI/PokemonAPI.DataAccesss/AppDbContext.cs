using Microsoft.EntityFrameworkCore;
using PokemonAPI.DataAccesss.Configuration;
using PokemonAPI.DataAccesss.Entities;

namespace PokemonAPI.DataAccesss;
/// <summary>
/// 
/// </summary>
public class AppDbContext: DbContext
{
    public DbSet<Breeding> Breedings { get; set; }
    public DbSet<Pokemon> Pokemons { get; set; }
    public DbSet<Ability> Abilities { get; set; }
    public DbSet<PockemonType> PockemonTypes { get; set; }
    public DbSet<Move> Moves { get; set; }
    
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new PockemonConfiguration());
        modelBuilder.ApplyConfiguration(new AbilityConfiguration());
        modelBuilder.ApplyConfiguration(new BreedingConfiguration());
        modelBuilder.ApplyConfiguration(new MoveConfiguration());
        modelBuilder.ApplyConfiguration(new PockemonTypeConfiguration());
    }
}