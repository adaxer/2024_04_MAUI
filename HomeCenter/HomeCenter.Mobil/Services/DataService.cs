using HomeCenter.Common.Data;
using Microsoft.EntityFrameworkCore;

namespace HomeCenter.Mobil.Services;
internal class DataService : IDataService
{
    private readonly HolidayContext _context;

    public DataService(HolidayContext context)
    {
        this._context = context;
    }

    public async Task<IReadOnlyCollection<Holiday>> GetAll()
    {
        return await _context.Holidays.ToListAsync();
    }

    public async Task Save(Holiday holiday)
    {
        _context.Add(holiday);
        await _context.SaveChangesAsync();
    }
}
