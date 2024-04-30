
namespace HomeCenter.Mobil.Interfaces;

public interface IHolidayService
{
  Task<IReadOnlyList<Holiday>> GetHolidays(string state, string year);
  IReadOnlyList<KeyValuePair<string, string>> GetStates();


}
