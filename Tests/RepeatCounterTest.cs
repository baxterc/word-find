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
      Assert.Equal(0, counter.CountRepeats("goodbye", "hello"));
    }
    [Fact]
    public void StringSameAsSearchWord_CountRepeats_1()
    {
      RepeatCounter counter = new RepeatCounter();
      Assert.Equal(1, counter.CountRepeats("hello", "hello"));
    }
    [Fact]
    public void StringDoesntContainSearchWord_CountRepeats_0()
    {
      RepeatCounter counter = new RepeatCounter();
      Assert.Equal(0, counter.CountRepeats("monkey", "donkey"));
    }
    [Fact]
    public void StringContainsSearchWord_CountRepeats_1()
    {
      RepeatCounter counter = new RepeatCounter();
      Assert.Equal(1, counter.CountRepeats("monkey", "monk"));
    }
  }
}
