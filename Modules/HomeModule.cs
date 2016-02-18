using Nancy;
using System.Collections.Generic;
using WeekDayFinders;
using System;

namespace WeekdayFinders
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
    Get["/"] = _ => View["index.cshtml"];
    }
  }
}
