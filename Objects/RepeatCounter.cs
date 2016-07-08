using System;
using System.Collections.Generic;
using System.IO;

namespace FindWord.Objects
{
  public class RepeatCounter
  {


    public int CountRepeats(string mainString, string searchWord)
    {
      int wordCount = 0;
      string[] stringWords = mainString.Split(' ');
      foreach (string w in stringWords)
      {
        if (w.Contains(searchWord))
        {
          wordCount ++;
        }
        else
        {
          continue;
        }
      }
      return wordCount;
    }
  }
}
