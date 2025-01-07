using Domain;

namespace Service.Interface;

public interface IStatsService
{
    public Task<Stats> GetStatsAsync();
}