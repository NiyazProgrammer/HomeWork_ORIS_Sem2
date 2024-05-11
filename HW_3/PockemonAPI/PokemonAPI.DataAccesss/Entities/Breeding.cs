using System.ComponentModel.DataAnnotations;

namespace PokemonAPI.DataAccesss.Entities;

public class Breeding
{ 
    [Key]
    public int Id { get; set; }
    public int Height { get; set; }
    public int Weight { get; set; }
    public int PockemonId { get; set;}
    public Pokemon Pockemon { get; set;}
}