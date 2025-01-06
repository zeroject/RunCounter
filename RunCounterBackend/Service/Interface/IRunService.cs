using Domain;

namespace Service.Interface;

public interface IRunService
{
    public Task<IEnumerable<Run>> GetRunsAsync();
    public Task<Run> GetRunByIdAsync(Guid id);
    public Task<Run> CreateRunAsync(Run run);
    public Task<Run> UpdateRunAsync(Guid id, Run run);
    public Task<Run> DeleteRunAsync(Guid id);
}