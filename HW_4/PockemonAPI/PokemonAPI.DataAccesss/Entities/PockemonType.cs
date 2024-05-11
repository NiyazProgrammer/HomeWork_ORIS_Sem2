using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PokemonAPI.DataAccesss.Entities;

public class PockemonType
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Pokemon> Pockemones{ get; set; }
}