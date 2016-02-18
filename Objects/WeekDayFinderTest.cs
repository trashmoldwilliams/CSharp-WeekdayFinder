using Xunit;
using WeekDayFinders;
using System;
using System.Collections.Generic;


namespace WeekDayFinderTest
{
  public class WeekDayFinderTester
  {
    [Fact]
    public void IsDate_forDateBeing01021800_thursday()
    {
      double year = 1800;
      double month = 1;
      double day = 2;
      Assert.Equal("Thursday", WeekDayFinder.FindWeekDay(month, day, year));
    }
    [Fact]
    public void IsDate_forDateBeing03011800_()
    {
      double year = 1800;
      double month = 3;
      double day = 1;
      Assert.Equal("Saturday", WeekDayFinder.FindWeekDay(month, day, year));
    }
  }
}
