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
      if (searchWord.Contains(" "))
      {
        int mainLength = mainString.Length;
        string searchedString = mainString.Replace(searchWord,"");
        wordCount = (mainLength-searchedString.Length) / searchWord.Length; // This checks if there's a string in the search word, then removes the search word from the main string every time it occurs.  The difference in the length of the original main string and the new string with the search words removed is then divided by the length of the search word, which is equal to the number of times the removal of the search word occurred, which in turn is equal to the number of matches that occurred.
      }
      else
      {
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
          else if (isInclusive == true && w.ToLower().Contains(searchWord.ToLower()) && w.ToLower() != searchWord.ToLower()) // the second condition prevents an exact match from being considered an inclusive match.  Otherwise, this clause would find matches that would be precluded by the case sensitive search, such as "This" and "this."  Exact, non-case-sensitive matches are handled in the first conditional statement.
          {
            wordCount ++;
          }
          else
          {
            continue;
          }
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
