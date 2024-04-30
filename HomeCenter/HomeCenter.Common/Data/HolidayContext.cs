using HomeCenter.Common.Models;
using Microsoft.EntityFrameworkCore;

namespace HomeCenter.Common.Data;
public  class HolidayContext : DbContext
{
    public DbSet<Holiday> Holidays { get; set; }

    public HolidayContext(DbContextOptions<HolidayContext> dbContextOptions) : base(dbContextOptions)
    {
        Database.EnsureCreated();
    }
}
