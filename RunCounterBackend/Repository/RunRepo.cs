using Domain;
using Microsoft.EntityFrameworkCore;
using Repository.Interface;

namespace Repository;

public class RunRepo : IRunRepo
{
    private readonly AppDbContext _context;

    public RunRepo(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Run>> GetRunsAsync()
    {
        return await _context.Runs.ToListAsync();
    }

    public async Task<Run> GetRunByIdAsync(Guid id)
    {
        return await _context.Runs.FirstOrDefaultAsync(r => r.Id == id);
    }

    public async Task<Run> CreateRunAsync(Run run)
    {
        await _context.Runs.AddAsync(run);
        await _context.SaveChangesAsync();
        return run;
    }

    public async Task<Run> UpdateRunAsync(Guid id, Run run)
    {
        var existingRun = await _context.Runs.FirstOrDefaultAsync(r => r.Id == id);
        if (existingRun == null)
        {
            return null;
        }

        existingRun.Name = run.Name;
        existingRun.Date = run.Date;
        existingRun.Distance = run.Distance;
        existingRun.Time = run.Time;
        existingRun.Pace = run.Pace;
        existingRun.Note = run.Note;

        await _context.SaveChangesAsync();
        return existingRun;
    }

    public async Task<Run> DeleteRunAsync(Guid id)
    {
        var existingRun = await _context.Runs.FirstOrDefaultAsync(r => r.Id == id);
        if (existingRun == null)
        {
            return null;
        }

        _context.Runs.Remove(existingRun);
        await _context.SaveChangesAsync();
        return existingRun;
    }
}