using Microsoft.AspNetCore.Mvc;
using MyApp;
using MyApp.Models;
using PockemonAPI;

namespace PokemonAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonController : ControllerBase
    {
        private static ServiceApi serviceApi = new ServiceApi();
        private static List<PokemonDto> data = serviceApi.Pokemons.Results;
        
        private readonly IPokemonApi _pokemonApi;

        /// <summary>
        /// Used for tests
        /// </summary>
        /// <param name="pokemonApi"></param>
        /*public PokemonController(IPokemonApi pokemonApi)
         {
             _pokemonApi = pokemonApi;
         }*/

        
        
        /// <summary>
        /// Метод для получения всех покемонов
        /// </summary>
        /// <returns>Возвращает список всех покемонов в системе</returns>
        // GET: api/PokemonDto
        [HttpGet]
        public IActionResult GetAll([FromQuery] string? page, [FromQuery] string? count)
        {
            int pageNumber = int.TryParse(page, out int parsedPage) ? parsedPage : 1; 
            int itemsPerPage = int.TryParse(count, out int parsedCount) ? parsedCount : data.Count(); 
            var pageData = data.Skip((pageNumber - 1) * itemsPerPage).Take(itemsPerPage);
            
            int totalCount = pageData.Count(); 
            var result = new
            {
                total = totalCount,
                data = pageData.Select(p => new
                {
                    p.Id,
                    p.Name,
                    p.Image,
                    p.Types,
                    p.Hp,
                    p.Atk,
                    p.Def,
                    p.Spd,
                    p.Breeding.Height,
                    p.Breeding.Weight
                })
            };

            return Ok(result);
        }

        /// <summary>
        /// Метод для получения покемонов по указанной строке пользователя
        /// </summary>
        /// <returns>Возвращает список всех найденых покемонов в системе</returns>
        [HttpGet("GetByFilter")]
        public IActionResult GetByFilter([FromQuery] string? name, [FromQuery] string? page, [FromQuery] string? count)
        {
            var filteredData = data.Where(p => p.Name.Contains(name, StringComparison.OrdinalIgnoreCase));
            
            int pageNumber = int.TryParse(page, out int parsedPage) ? parsedPage : 1; 
            int itemsPerPage = int.TryParse(count, out int parsedCount) ? parsedCount : filteredData.Count(); 
            var pageData = filteredData.Skip((pageNumber - 1) * itemsPerPage).Take(itemsPerPage);
            var totalCount = itemsPerPage;
            var result = new
            {
                total = totalCount,
                data = pageData.Select(p => new
                {
                    p.Id,
                    p.Name,
                    p.Image,
                    p.Types,
                    p.Hp,
                    p.Atk,
                    p.Def,
                    p.Spd,
                    p.Breeding.Height,
                    p.Breeding.Weight
                })
            };

            return Ok(result);
        }

        /// <summary>
        /// Метод для получения всей информации по одному покемону
        /// </summary>
        /// <returns>Возвращает полную информацию о покемоне по заданному Id или Name</returns>
        // GET: api/PokemonDto/5
        [HttpGet("{nameOrId}")]
        public PokemonDto GetByIdOrName([FromRoute] string nameOrId)
        {
            int id = 0;
            if (int.TryParse(nameOrId, out id))
                return data.FirstOrDefault(p => p.Id == id);
            else
                return data.FirstOrDefault(p => p.Name.Equals(nameOrId, StringComparison.OrdinalIgnoreCase));
        }
    }
}
