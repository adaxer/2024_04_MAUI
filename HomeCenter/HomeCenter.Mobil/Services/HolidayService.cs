

using Microsoft.Extensions.Logging;

namespace HomeCenter.Mobil.Services;

internal class HolidayService : IHolidayService
{
  private readonly ILogger<HolidayService> _logger;
  private readonly string _baseAddress;
  private HttpClient _client;

  public HolidayService(Config config, ILogger<HolidayService> logger)
  {
    _logger = logger;
    _baseAddress = config.ServiceAddress;
  }

  public async Task<IReadOnlyList<Holiday>> GetHolidays(string state, string year)
  {
    _client = new HttpClient();
    var requestUri = $"{_baseAddress}/?jahr={year}&nur_land={state}";
    var response = await _client.GetAsync(requestUri);
    if(response.IsSuccessStatusCode)
    {
      string json = await response.Content.ReadAsStringAsync();
      return Holiday.ReadFromJson(json);
    }
    else
    {
      _logger.LogError($"Could not get Holidays, Statuscode: {response.StatusCode}");
      return new List<Holiday>();
    }
  }

  public IReadOnlyList<KeyValuePair<string, string>> GetStates()
  {
    return new Dictionary<string, string>
    {
      {"BW", "Baden-Württemberg"    },
      {"BY", "Bayern"                },
      {"BE", "Berlin"                },
      {"BB", "Brandenburg"           },
      {"HB", "Bremen"                },
      {"HH", "Hamburg"               },
      {"HE", "Hessen"                },
      {"MV", "Mecklenburg-Vorpommern"},
      {"NI", "Niedersachsen"         },
      {"NW", "Nordrhein-Westfalen"   },
      {"RP", "Rheinland-Pfalz"       },
      {"SL", "Saarland"              },
      {"SN", "Sachsen"               },
      {"ST", "Sachsen-Anhalt"        },
      {"SH", "Schleswig-Holstein"    },
      {"TH", "Thüringen"             }
    }.ToList();
  }
}
