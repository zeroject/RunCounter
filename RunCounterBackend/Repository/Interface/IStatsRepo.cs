using Domain;

namespace Repository.Interface;

public interface IStatsRepo
{
    public Task<Stats> GetStatsAsync();
}