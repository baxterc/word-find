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
      Assert.Equal(0, counter.CountRepeats("goodbye", "hello", false));
    }
    [Fact]
    public void StringSameAsSearchWord_CountRepeats_1()
    {
      RepeatCounter counter = new RepeatCounter();
      Assert.Equal(1, counter.CountRepeats("hello", "hello", false));
    }
    [Fact]
    public void StringDoesntContainSearchWord_CountRepeats_0()
    {
      RepeatCounter counter = new RepeatCounter();
      Assert.Equal(0, counter.CountRepeats("monkey", "donkey", true));
    }
    [Fact]
    public void StringContainsSearchWord_CountRepeats_1()
    {
      RepeatCounter counter = new RepeatCounter();
      Assert.Equal(1, counter.CountRepeats("monkey", "monk", true));
    }
    [Fact]
    public void TwoWordStringDoesntContainSearchWord_CountRepeats_0()
    {
      RepeatCounter counter = new RepeatCounter();
      Assert.Equal(0, counter.CountRepeats("hello world", "goodbye", false));
    }
    [Fact]
    public void TwoWordStringContainsSearchWord_CountRepeats_1()
    {
      RepeatCounter counter = new RepeatCounter();
      Assert.Equal(1, counter.CountRepeats("hello world", "hello", false));
    }
    [Fact]
    public void MultiWordStringContainsSearchWordTwice_CountRepeats_2()
    {
      RepeatCounter counter = new RepeatCounter();
      Assert.Equal(2, counter.CountRepeats("beep beep", "beep", false));
    }
    [Fact]
    public void MultiWordStringSeparatedByHyphen_CountRepeats_2()
    {
      RepeatCounter counter = new RepeatCounter();
      Assert.Equal(2, counter.CountRepeats("honk-honk", "honk", false));
    }
    [Fact]
    public void ThreeWordsIncludeSearchWord_CountRepeats_3()
    {
      RepeatCounter counter = new RepeatCounter();
      Assert.Equal(3, counter.CountRepeats("loopy loop bloopers", "loop", true));
    }
  }
}
