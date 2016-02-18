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
  }
}
