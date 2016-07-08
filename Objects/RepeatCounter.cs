using System;
using System.Collections.Generic;
using System.IO;

namespace FindWord.Objects
{
  public class RepeatCounter
  {
    public int CountRepeats(string mainString, string searchWord, bool isInclusive, bool isCaseSensitive)
    {
      int wordCount = 0;
      string[] stringWords = mainString.Split(' ', ',', '.', '-', '_', '!', '.', '?', ':', ';', '/');
      foreach (string w in stringWords)
      {
        if (isCaseSensitive == false && w.ToLower() == searchWord.ToLower())
        {
          wordCount ++;
        }
        else if (isCaseSensitive == true && w == searchWord)
        {
          wordCount ++;
        }
        else if (isInclusive == true && w.ToLower().Contains(searchWord.ToLower()) && w.ToLower() != searchWord.ToLower()) // this prevents an exact match from being considered an inclusive match in cases where the user wants a case-sensitive match but not an inclusive match.
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

    public string HTMLOutput(int wordSum)
    {
      if (wordSum <= 0)
      {
        return "Sorry, your word wasn't found in the text.";
      }
      else if (wordSum == 1)
      {
        return "Your word was found " + wordSum + " time!";
      }
      else
      {
        return "Your word was found " + wordSum + " times!";
      }
    }
  }
}
