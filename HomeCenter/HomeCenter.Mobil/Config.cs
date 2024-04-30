namespace HomeCenter.Mobil;

public class Config
{
    public string ServiceAddress => "https://www.feiertage-api.de/api";

    public string DbConnection => Path.Combine(Microsoft.Maui.Storage.FileSystem.AppDataDirectory, "Holidays.db");
}
