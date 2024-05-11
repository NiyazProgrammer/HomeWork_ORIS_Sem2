using MyApp.Models;
using Newtonsoft.Json;

namespace MyApp;

public class ServiceApi
{
    public PokemonData Pokemons = new PokemonData();

    public ServiceApi()
    {
        string jsonString = File.ReadAllText("/Users/niyazrizvanov/ORIS_Semestr_2/PockemonAPI/MyServiceAPI_2/PokemonsJson.json");
        Pokemons= JsonDeserializer.DeserializeJson(jsonString);
    }
    
    private class JsonDeserializer
    {
        public static PokemonData DeserializeJson(string jsonString)
        {
            PokemonData data = JsonConvert.DeserializeObject<PokemonData>(jsonString);
            return data;
        }
    }
}

