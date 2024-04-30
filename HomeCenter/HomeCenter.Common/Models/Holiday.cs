namespace HomeCenter.Common.Models;

public record Holiday(string Name, DateTime Date, string Description)
{
    public Guid Id { get; set; } = Guid.NewGuid();

    public static IReadOnlyList<Holiday> ReadFromJson(string json)
    {
        return new List<Holiday>
        {
            new Holiday("Ostern", DateTime.Now, "Eier suchen"),
            new Holiday("Pfingsten", new DateTime(2024, 6, 3), "Schönes Wetter"),
            new Holiday("Fasching", DateTime.Now.AddMonths(-3), "verkleiden")
        };
    }
}
