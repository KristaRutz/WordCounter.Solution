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
      int matches = 0;
      if (Word == "")
      {
        return 0;
      }
      string[] words = Str.Split(" ");
      foreach (string word in words)
      {
        Console.WriteLine(word);
        matches++;
      }
      return matches;
    }
  }
}