using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
  public class RepeatCounter
  {
    public string Word { get; set; }
    public string Str { get; set; }

    public RepeatCounter() { }
    public RepeatCounter(string word, string str) : this()
    {
      Word = word;
      Str = str;
    }

    public int Matches()
    {
      if (!Validate())
      {
        return 0;
      }

      int matches = 0;
      string[] words = Str.Split(" ");
      foreach (string word in words)
      {
        Console.WriteLine(word);
        if (RemovePunctuation(word) == RemovePunctuation(Word))
        {
          matches++;
        }
      }
      return matches;
    }

    public static string RemovePunctuation(string input)
    {
      string output = input;

      // recursively remove prefixed punctuation
      if (!Char.IsLetterOrDigit(output[0]))
      {
        output = output.Substring(1);
        output = RemovePunctuation(output);
      }

      //recursively remove suffixed punctuation
      if (!Char.IsLetterOrDigit(output[output.Length - 1]))
      {
        output = output.Substring(0, output.Length - 1);
        output = RemovePunctuation(output);
      }
      return output;
    }

    public bool Validate()
    {
      if (Word == "" || Str == "")
      {
        return false;
      }
      return true;
    }
  }
}