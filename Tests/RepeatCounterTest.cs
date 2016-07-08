using Xunit;
using System;
using System.IO;
using System.Collections.Generic;
using FindWord.Objects;

namespace FindWord
{
  public class RepeatCounterTest
  {
    [Fact]
    public void StringDifferentFromSearchWord_CountRepeats_0()
    {
      RepeatCounter counter = new RepeatCounter();
      Assert.Equal(0, counter.CountRepeats("goodbye", "hello", false, false));
    }
    [Fact]
    public void StringSameAsSearchWord_CountRepeats_1()
    {
      RepeatCounter counter = new RepeatCounter();
      Assert.Equal(1, counter.CountRepeats("hello", "hello", false, false));
    }
    [Fact]
    public void StringDoesntContainSearchWord_CountRepeats_0()
    {
      RepeatCounter counter = new RepeatCounter();
      Assert.Equal(0, counter.CountRepeats("monkey", "donkey", true, false));
    }
    [Fact]
    public void StringContainsSearchWord_CountRepeats_1()
    {
      RepeatCounter counter = new RepeatCounter();
      Assert.Equal(1, counter.CountRepeats("monkey", "monk", true, false));
    }
    [Fact]
    public void TwoWordStringDoesntContainSearchWord_CountRepeats_0()
    {
      RepeatCounter counter = new RepeatCounter();
      Assert.Equal(0, counter.CountRepeats("hello world", "goodbye", false, false));
    }
    [Fact]
    public void TwoWordStringContainsSearchWord_CountRepeats_1()
    {
      RepeatCounter counter = new RepeatCounter();
      Assert.Equal(1, counter.CountRepeats("hello world", "hello", false, false));
    }
    [Fact]
    public void MultiWordStringContainsSearchWordTwice_CountRepeats_2()
    {
      RepeatCounter counter = new RepeatCounter();
      Assert.Equal(2, counter.CountRepeats("beep beep", "beep", false, false));
    }
    [Fact]
    public void MultiWordStringSeparatedByHyphen_CountRepeats_2()
    {
      RepeatCounter counter = new RepeatCounter();
      Assert.Equal(2, counter.CountRepeats("honk-honk", "honk", false, false));
    }
    [Fact]
    public void ThreeWordsIncludeSearchWord_CountRepeats_3()
    {
      RepeatCounter counter = new RepeatCounter();
      Assert.Equal(3, counter.CountRepeats("loopy loop bloopers", "loop", true, false));
    }
    [Fact]
    public void MatchWordAndStringCaseSensitive_CountRepeats_0()
    {
      RepeatCounter counter = new RepeatCounter();
      Assert.Equal(0, counter.CountRepeats("test", "Test", false, true));
    }
    [Fact]
    public void MatchWordAndStringCaseInsensitive_CountRepeats_1()
    {
      RepeatCounter counter = new RepeatCounter();
      Assert.Equal(1, counter.CountRepeats("test", "Test", false, false));
    }
    [Fact]
    public void NoWordMatch_HTMLOutput_NoMatchesFound()
    {
      RepeatCounter counter = new RepeatCounter();
      int htmlTest = counter.CountRepeats("goodbye", "hello", false, false);
      Assert.Equal("Sorry, your word wasn't found in the text.", counter.HTMLOutput(htmlTest));
    }
    [Fact]
    public void OneWordMatch_HTMLOutput_OneMatchFound()
    {
      RepeatCounter counter = new RepeatCounter();
      int htmlTest = counter.CountRepeats("goodbye", "goodbye", false, false);
      Assert.Equal("Your word was found 1 time!", counter.HTMLOutput(htmlTest));
    }
    [Fact]
    public void ThreeWordMatches_HTMLOutput_ThreeMatchesFound()
    {
      RepeatCounter counter = new RepeatCounter();
      int htmlTest = counter.CountRepeats("beep beep beep", "beep", false, false);
      Assert.Equal("Your word was found 3 times!", counter.HTMLOutput(htmlTest));
    }
  }
}
