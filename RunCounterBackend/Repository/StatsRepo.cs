using Domain;
using Microsoft.EntityFrameworkCore;
using Repository.Interface;

namespace Repository;

public class StatsRepo : IStatsRepo 
{
    private readonly AppDbContext _context;
    
    public StatsRepo(AppDbContext context)
    {
        _context = context;
    }
    
    public async Task<Stats> GetStatsAsync()
    {
        var stats = new Stats();
        var now = DateTime.UtcNow;

        // Total stats
        var allRuns = await _context.Runs.ToListAsync();
        stats.TotalDistance = allRuns.Sum(r => r.Distance);
        stats.TotalTime = allRuns.Sum(r => r.Time);
        var totalRunCount = allRuns.Count;

        stats.AveragePacePerRunInTotal = totalRunCount > 0 ? allRuns.Average(r => r.Pace) : 0;
        stats.AverageDistancePerRunInTotal = totalRunCount > 0 ? allRuns.Average(r => r.Distance) : 0;
        stats.AverageTimePerRunInTotal = totalRunCount > 0 ? allRuns.Average(r => r.Time) : 0;

        // Last month stats
        var lastMonthRuns = allRuns.Where(r => r.Date >= now.AddMonths(-1)).ToList();
        var lastMonthRunCount = lastMonthRuns.Count;

        stats.AveragePacePerRunInLastMonth = lastMonthRunCount > 0 ? lastMonthRuns.Average(r => r.Pace) : 0;
        stats.AverageDistancePerRunInLastMonth = lastMonthRunCount > 0 ? lastMonthRuns.Average(r => r.Distance) : 0;
        stats.AverageTimePerRunInLastMonth = lastMonthRunCount > 0 ? lastMonthRuns.Average(r => r.Time) : 0;

        // Last week stats
        var lastWeekRuns = allRuns.Where(r => r.Date >= now.AddDays(-7)).ToList();
        var lastWeekRunCount = lastWeekRuns.Count;

        stats.AveragePacePerRunInLastWeek = lastWeekRunCount > 0 ? lastWeekRuns.Average(r => r.Pace) : 0;
        stats.AverageDistancePerRunInLastWeek = lastWeekRunCount > 0 ? lastWeekRuns.Average(r => r.Distance) : 0;
        stats.AverageTimePerRunInLastWeek = lastWeekRunCount > 0 ? lastWeekRuns.Average(r => r.Time) : 0;

        return stats;
    }
}