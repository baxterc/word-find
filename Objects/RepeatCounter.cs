using System;
using System.Collections.Generic;
using System.IO;

namespace FindWord.Objects
{
  public class RepeatCounter
  {
    public int CountRepeats(string mainString, string searchWord, bool isInclusive)
    {
      int wordCount = 0;
      string[] stringWords = mainString.Split(' ', ',', '.', '-', '_', '!', '.', '?', ':', ';', '/');
      foreach (string w in stringWords)
      {
        if (w == searchWord)
        {
          wordCount ++;
        }
        else if (isInclusive == true && w.Contains(searchWord))
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
