using System;
using MyApp.Models;
using Newtonsoft.Json;
using Formatting = System.Xml.Formatting;

namespace ServiceApi;

class Program
{
    // static Pokemon Pokemons = new Pokemon();
        private static ListPokemons Pokemons = new ListPokemons();
        // private static List<Pokemon> pokemons =  new List<Pokemon>();
        static async Task Main(string[] args)
        {
            string apiUrl = "https://pokeapi.co/api/v2/pokemon?limit=151"; 
        
            try
            {
                var results = await GetResultsFromApi(apiUrl);
                SetPokemons(results);
                
                var result = await GetPokemonCharactors(results[0]);
                // Console.WriteLine($"Stat name: {result.Stats[0].Stat.Name}, Number: {result.Stats[0].Base_stat}");
                // Console.WriteLine($"Move name: {result.Moves[0].move.Name}");
                // Console.WriteLine($"Height: {result.Height}");
                // Console.WriteLine($"Weight: {result.Weight}");
                
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при получении данных: {ex.Message}");
            }
        }

        static void SetPokemons(List<Pokemon> results)
        {
            foreach (Pokemon pokemon in results)
            {
                Pokemons.Results.Add(pokemon);
                // Console.WriteLine($"Name: {pokemons[0].Name}, URL: {pokemons[0].URL}");
                // Console.WriteLine(pokemons.Count);
            }
        }

        static async Task<List<Pokemon>> GetResultsFromApi(string apiUrl)
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(apiUrl); response.EnsureSuccessStatusCode(); // Генерирует исключение в случае ошибки HTTP

                string jsonData = await response.Content.ReadAsStringAsync();
                
                ListPokemons listPokemons = JsonConvert.DeserializeObject<ListPokemons>(jsonData);
                return listPokemons.Results;
            }
        }

        static async Task<PokemonCharactors> GetPokemonCharactors(Pokemon pokemon)
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(pokemon.URL);
                response.EnsureSuccessStatusCode();
                
                string jsonData = await response.Content.ReadAsStringAsync();
                PokemonCharactors pokemonCharactors = JsonConvert.DeserializeObject<PokemonCharactors>(jsonData);
                return pokemonCharactors;
            }
        }
            // public static string ConvertListPokemonsToJson(ListPokemons listPokemons)
            // {
            //     string json = JsonConvert.SerializeObject(listPokemons, Formatting.Indented);
            //     return json;
            // }
}