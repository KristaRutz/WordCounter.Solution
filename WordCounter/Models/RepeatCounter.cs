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
      // char[] inputChars = input.ToCharArray();
      // List<char> sansOuterPunctuation = new List<char>();
      // for (int i = 0; i < inputChars.Length; i++)
      // {
      //   if (IsLetterOrDigit(inputChars[i]))
      //   {
      //     break;
      //   } 
      //   else
      //   {

      //   }
      // }

      string output = input;

      // for (int index = 0; index < input.Length; index++)
      // {
      //   string modified = output;
      //   if (!Char.IsLetterOrDigit(input, index))
      //   {
      //     output = output.Substring(index);
      //   }
      //   else
      //   {
      //     break;
      //   }
      // }

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