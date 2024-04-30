
namespace HomeCenter.Mobil.Services;

internal class HolidayService : IHolidayService
{
  public IReadOnlyList<KeyValuePair<string, string>> GetStates()
  {
    return new Dictionary<string, string>
    {
      { "BW", "Baden-Württemberg"    },
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
