using React.PokemonApi.Models;

namespace React.PokemonApi.Services;

/// <summary>
/// Interface for the Pokemon repository.
/// </summary>
public interface IPokemonRepository
{
    Task<IEnumerable<Pokemon>> GetAllAsync();
    Task<Pokemon> GetByIdAsync(int id);
}
