using System;
using System.Collections.Generic;
using System.IO;

namespace FindWord.Objects
{
  public class RepeatCounter
  {


    public int CountRepeats(string mainString, string searchWord)
    {
      if (mainString == searchWord)
      {
        return 1;
      }
      else
      {
        return 0;
      }
    }
  }
}
