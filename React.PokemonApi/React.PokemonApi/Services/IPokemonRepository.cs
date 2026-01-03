using React.PokemonApi.Models;

namespace React.PokemonApi.Services;
public interface IPokemonRepository
{
    Task<IEnumerable<Pokemon>> GetAllAsync();
    Task<Pokemon> GetByIdAsync(int id);
}
