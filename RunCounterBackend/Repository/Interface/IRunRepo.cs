using Domain;

namespace Repository.Interface;

public interface IRunRepo
{
    public Task<IEnumerable<Run>> GetRunsAsync();
    public Task<Run> GetRunByIdAsync(Guid id);
    public Task<Run> CreateRunAsync(Run run);
    public Task<Run> UpdateRunAsync(Guid id, Run run);
    public Task<Run> DeleteRunAsync(Guid id);
}