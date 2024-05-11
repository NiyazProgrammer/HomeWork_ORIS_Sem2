namespace MyApp.Models;

public class PokemonDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Image { get; set; }
    public int Hp { get; set; }
    public int Atk { get; set; }
    public int Def { get; set; }
    public int Spd { get; set; }
    public List<string> Types { get; set; }
    public Breeding Breeding { get; set; }
}
