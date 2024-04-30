using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.Input;

namespace HomeCenter.Mobil.ViewModels;

public partial class HolidaysViewModel : ObservableObject
{
    private readonly IHolidayService _holidayService;
    private readonly IDataService _dataService;

    public HolidaysViewModel(IHolidayService holidayService, IDataService dataService)
    {
        Title = "Holidays";
        _holidayService = holidayService;
        this._dataService = dataService;
        _states = _holidayService.GetStates().ToList();
        _selectedState = _states.First();
    }

    [ObservableProperty]
    private string _title;

    [ObservableProperty]
    private List<KeyValuePair<string, string>> _states;

    [ObservableProperty]
    private KeyValuePair<string, string> _selectedState;

    [ObservableProperty]
    private string _selectedYear;

    [ObservableProperty]
    private List<Holiday> _holidays;

    [RelayCommand]
    private async Task GetData()
    {
        Holidays = new List<Holiday>(await _holidayService.GetHolidays(SelectedState.Key, SelectedYear));
        await _dataService.Save(Holidays.First());

        var holis = await _dataService.GetAll();
    }
}
