using Microsoft.AspNetCore.Mvc;
using MyApp.Models;

namespace PockemonAPI;

public interface IPokemonApi
{
    public IEnumerable<PokemonDto> GetAll([FromQuery] string? page, [FromQuery] string? count);
    public IActionResult GetByFilter([FromQuery] string? name, [FromQuery] string? page, [FromQuery] string? count);
    public PokemonDto GetByIdOrName([FromRoute] string nameOrId);
}