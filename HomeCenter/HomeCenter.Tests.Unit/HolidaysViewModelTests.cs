using FluentAssertions;
using HomeCenter.Common.Models;
using HomeCenter.Mobil.Interfaces;
using HomeCenter.Mobil.ViewModels;
using NSubstitute;

namespace HomeCenter.Tests.Unit;
public class HolidaysViewModelTests
{
    [Fact]
    public async Task GetData_FillsHolidayList()
    {
        // Arrange
        HolidaysViewModel vm = CreateViewModelWithMocks();

        // Act
        await vm.GetDataCommand.ExecuteAsync(null);

        // Assert
        vm.Holidays.Should().HaveCount(1);
    }

    private HolidaysViewModel CreateViewModelWithMocks()
    {
        var dataMock = Substitute.For<IDataService>();
        var holiMock = Substitute.For<IHolidayService>();
        holiMock.GetStates().Returns(new List<KeyValuePair<string, string>> { new KeyValuePair<string, string>("BY", "Bayern") });
        holiMock.GetHolidays(Arg.Any<string>(), Arg.Any<string>()).Returns(new List<Holiday> { new Holiday("Name", DateTime.Now, "Desciption") });
        var result = new HolidaysViewModel(holiMock, dataMock);
        return result;
    }
}
