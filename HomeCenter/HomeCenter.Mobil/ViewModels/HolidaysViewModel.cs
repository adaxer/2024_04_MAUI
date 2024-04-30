namespace HomeCenter.Mobil.ViewModels;

public partial class HolidaysViewModel : ObservableObject
{
  private readonly IHolidayService _holidayService;
  
  public HolidaysViewModel(IHolidayService holidayService)
  {
    Title = "Holidays";
    _holidayService = holidayService;
  }

  [ObservableProperty]
  private string _title;
}
