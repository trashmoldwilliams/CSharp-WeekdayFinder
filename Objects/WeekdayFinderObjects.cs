using System;
using System.Collections.Generic;
namespace WeekDayFinders
{
    public class WeekDayFinder
  {
      private string _day;
      private string _month;
      private string _year;
//constructor//

    public WeekDayFinder()
    {

    }

    public static string FindWeekDay(double month, double day, double year)
     {
       var daysSinceAnchor = ((year - 1800) * 365) + ((month - 1) * 30) + day;

       double weekdayNumber = daysSinceAnchor % 7;

       Dictionary<double, string> testWeek = new Dictionary<double, string> {};
       testWeek.Add(1, "Wedensday");
       testWeek.Add(2, "Thursday");
       testWeek.Add(3, "Friday");
       testWeek.Add(4, "Saturday");
       testWeek.Add(5, "Sunday");
       testWeek.Add(6, "Monday");
       testWeek.Add(7, "Tuesday");

       string output = "";

       foreach (KeyValuePair<double, string> test in testWeek)
       {
         if( weekdayNumber == test.Key)
         {
           output = test.Value;
         }
       }

       return output;
     }

// getters and setters for properties//

  }
}
