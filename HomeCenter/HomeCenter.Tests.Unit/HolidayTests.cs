using FluentAssertions;
using HomeCenter.Common.Models;

namespace HomeCenter.Tests.Unit;

public class HolidayTests
{
    [Fact]
    public async Task ReadFromJson_WithCorrectInput_ReturnsHolidays()
    {
        // Arrange
        string json = await File.ReadAllTextAsync("HolidayTestData.json");

        // Act
        var result = Holiday.ReadFromJson(json);

        // Assert
        result.Should().HaveCountGreaterThan(0);
    }
}
