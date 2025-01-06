using Domain;
using Repository.Interface;
using Service.Interface;

namespace Service;

public class RunService : IRunService
{
    private readonly IRunRepo _runRepo;

    public RunService(IRunRepo runRepo)
    {
        _runRepo = runRepo;
    }

    public async Task<IEnumerable<Run>> GetRunsAsync()
    {
        return await _runRepo.GetRunsAsync();
    }

    public async Task<Run> GetRunByIdAsync(Guid id)
    {
        return await _runRepo.GetRunByIdAsync(id);
    }

    public async Task<Run> CreateRunAsync(Run run)
    {
        return await _runRepo.CreateRunAsync(run);
    }

    public async Task<Run> UpdateRunAsync(Guid id, Run run)
    {
        return await _runRepo.UpdateRunAsync(id, run);
    }

    public async Task<Run> DeleteRunAsync(Guid id)
    {
        return await _runRepo.DeleteRunAsync(id);
    }
}