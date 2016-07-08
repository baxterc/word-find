using System;
using System.Collections.Generic;
using Nancy;
using FindWord.Objects;

namespace FindWord
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Post["/count"] = _ => {
        RepeatCounter counter = new RepeatCounter();
        int count = counter.CountRepeats(Request.Form["full-string"], Request.Form["find-word"], Request.Form["inclusive"], Request.Form["case-sensitive"]);
        string pageOutput = counter.HTMLOutput(count);
        return View["count.cshtml", pageOutput];
      };
    }
  }
}
