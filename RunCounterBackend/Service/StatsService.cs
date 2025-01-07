using Domain;
using Repository.Interface;
using Service.Interface;

namespace Service;

public class StatsService : IStatsService
{
    private readonly IStatsRepo _repo;

    public StatsService(IStatsRepo repo)
    {
        _repo = repo;
    }

    public async Task<Stats> GetStatsAsync()
    {
        return await _repo.GetStatsAsync();
    }
}