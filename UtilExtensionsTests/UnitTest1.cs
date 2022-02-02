using System;
using Xunit;
using UtilExtensions;
namespace UtilExtensionsTests;

public class DateExtensionTests
{
    [Fact]
    public void CanDeconstructDates()
    {
        var birthDay = new DateTime(1969, 4, 20);

        var (month, day, year) = birthDay;
        
        Assert.Equal(4, month);
        Assert.Equal(20, day);
        Assert.Equal(1969, year);

    }

    [Fact]
    public void DeconstructPartialDate()
    {
        var birthDay = new DateTime(1969, 4, 20);

        var( _, _, year) = birthDay;
        
        Assert.Equal(1969, year);
        // Tada!
    }
}