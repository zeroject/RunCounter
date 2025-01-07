using Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.Interface;

namespace RestAPI.Controllers;

[Authorize]
[ApiController]
[Route("api/[controller]")]
public class RunController : ControllerBase
{
    private readonly IRunService _runService;

    public RunController(IRunService runService)
    {
        _runService = runService;
    }

    [HttpGet]
    public async Task<IEnumerable<Run>> GetRunsAsync()
    {
        return await _runService.GetRunsAsync();
    }

    [HttpGet("{id}")]
    public async Task<Run> GetRunByIdAsync(Guid id)
    {
        return await _runService.GetRunByIdAsync(id);
    }

    [HttpPost]
    public async Task<Run> CreateRunAsync(Run run)
    {
        return await _runService.CreateRunAsync(run);
    }

    [HttpPut("{id}")]
    public async Task<Run> UpdateRunAsync(Guid id, Run run)
    {
        return await _runService.UpdateRunAsync(id, run);
    }

    [HttpDelete("{id}")]
    public async Task<Run> DeleteRunAsync(Guid id)
    {
        return await _runService.DeleteRunAsync(id);
    }
}