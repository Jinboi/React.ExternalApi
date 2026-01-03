using Microsoft.AspNetCore.Mvc;
using React.ExternalApi.Services;

[ApiController]
[Route("api/[controller]")]
public class StudentsController : ControllerBase
{
    private readonly IStudentRepository _repo;

    public StudentsController(IStudentRepository repo)
    {
        _repo = repo;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var students = await _repo.GetAllAsync();
        return Ok(students);
    }
}
