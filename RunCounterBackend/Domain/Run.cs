namespace Domain;

public class Run
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public DateTime Date { get; set; }
    public double Distance { get; set; }
    public double Time { get; set; }
    public double Pace { get; set; }
    public string? Note { get; set; }
}