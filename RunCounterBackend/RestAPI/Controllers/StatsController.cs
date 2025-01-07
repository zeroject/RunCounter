using Domain;
using Microsoft.AspNetCore.Mvc;
using Service.Interface;

namespace RestAPI.Controllers;

[ApiController]
[Route("api/[controller]")] 
public class StatsController : ControllerBase
{
    private readonly IStatsService _service;

    public StatsController(IStatsService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<ActionResult<Stats>> GetStatsAsync()
    {
        try
        {
            return Ok(await _service.GetStatsAsync());
        }
        catch (Exception e)
        {
            return StatusCode(500, e.Message);
        }
    }
}