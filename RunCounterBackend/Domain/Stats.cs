namespace Domain;

public class Stats
{
    public double TotalDistance { get; set; }
    public double TotalTime { get; set; }
    // TOTAL
    public double AveragePacePerRunInTotal { get; set; }
    public double AverageDistancePerRunInTotal { get; set; }
    public double AverageTimePerRunInTotal { get; set; }
    // LAST MONTH
    public double AveragePacePerRunInLastMonth { get; set; }
    public double AverageDistancePerRunInLastMonth { get; set; }
    public double AverageTimePerRunInLastMonth { get; set; }
    // LAST WEEK
    public double AveragePacePerRunInLastWeek { get; set; } 
    public double AverageDistancePerRunInLastWeek { get; set; }
    public double AverageTimePerRunInLastWeek { get; set; }
}