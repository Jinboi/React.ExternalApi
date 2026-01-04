using Microsoft.EntityFrameworkCore;
using React.PokemonApi.Models;

namespace React.PokemonApi.Data;

/// <summary>
/// Represents the Entity Framework Core database context for the Pokemon data store.
/// </summary>
public class PokemonDataContext : DbContext
{

    public PokemonDataContext(DbContextOptions<PokemonDataContext> options) : base(options)
    {
    }


    public DbSet<Pokemon> Pokemon{ get; set; }

}
