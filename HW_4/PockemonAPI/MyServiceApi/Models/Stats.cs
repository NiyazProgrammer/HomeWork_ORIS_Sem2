namespace MyApp.Models;

public class Stats
{
    public string Base_stat { get; set; }
    public Stat Stat { get; set; }
}

public class Stat
{
    public string Name { get; set; }
}