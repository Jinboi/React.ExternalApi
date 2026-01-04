using Microsoft.AspNetCore.Mvc;
using React.PokemonApi.Services;

/// <summary>
/// This controller takes API requests and passes them to the repository.
/// </summary>
[ApiController]
[Route("api/[controller]")]
public class PokemonController : ControllerBase
{
    private readonly IPokemonRepository _repo;

    public PokemonController(IPokemonRepository repo)
    {
        _repo = repo;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var pokemon = await _repo.GetAllAsync();
        return Ok(pokemon);
    }
}