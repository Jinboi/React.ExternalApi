namespace React.PokemonApi.Models;

/// <summary>
/// Represents a Pokemon entity.
/// </summary>
public class Pokemon
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Index { get; set; }
    public string SpriteUrl { get; set; }
    public string Type { get; set; }
    public string Description { get; set; }
}
