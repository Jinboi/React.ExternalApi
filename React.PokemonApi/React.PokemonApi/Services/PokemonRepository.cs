using React.PokemonApi.Data;
using React.PokemonApi.Models;
using Microsoft.EntityFrameworkCore;

namespace React.PokemonApi.Services;

/// <summary>
/// This repository talks to the database and handles data operations for Pokemon entities.
/// </summary>
public class PokemonRepository : IPokemonRepository
{
    private readonly PokemonDataContext _context;

    public PokemonRepository(PokemonDataContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Pokemon>> GetAllAsync()
    {
        return await _context.Pokemon.ToListAsync();
    }

    public async Task<Pokemon> GetByIdAsync(int id)
    {
        return await _context.Pokemon.FindAsync(id);
    }
}

