using System;

namespace WordCounter.Models
{
  public class RepeatCounter
  {
    public string Word { get; set; }
    public string Str { get; set; }

    public RepeatCounter()
    {

    }
    public RepeatCounter(string word, string str) : this()
    {
      Word = word;
      Str = str;
    }

    public int Matches()
    {
      return 0;
    }
  }
}