using HomeCenter.Mobil.Services;
using Microsoft.Extensions.Logging;

namespace HomeCenter.Mobil;
public static class MauiProgram
{
  public static MauiApp CreateMauiApp()
  {
    var builder = MauiApp.CreateBuilder();
    builder
        .UseMauiApp<App>()
        .ConfigureFonts(fonts =>
        {
          fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
          fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
        });

    builder.Services.AddSingleton<IHolidayService, HolidayService>();

    builder.Services.AddTransient<HolidaysPage>();
    builder.Services.AddTransient<HolidaysViewModel>();

#if DEBUG
    builder.Logging.AddDebug();
#endif

    return builder.Build();
  }
}
