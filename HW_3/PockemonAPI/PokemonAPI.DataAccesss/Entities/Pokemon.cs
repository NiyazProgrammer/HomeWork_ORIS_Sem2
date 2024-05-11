using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PokemonAPI.DataAccesss.Entities;

public class Pokemon
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string ImageUrl { get; set; }
    public int BreedingId { get; set; }
    public int Hp { get; set; }
    public int Attack { get; set; }
    public int Defense { get; set; }
    public int Speed { get; set; }
    public Breeding Breeding { get; set; }
    public List<Ability> Abilities { get; set; }
    public List<Move> Moves { get; set; }
    public List<PockemonType> PokemonTypes { get; set; }
}