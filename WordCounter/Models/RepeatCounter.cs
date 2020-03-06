using System;

namespace WordCounter.Models
{
  public class RepeatCounter
  {
    public string Word { get; set; }
    public string Str { get; set; }

    public bool CaseSensitive { get; set; } = true;

    public RepeatCounter() { }
    public RepeatCounter(string word, string str) : this()
    {
      Word = word;
      Str = str;
    }

    public void NewSearch()
    {
      Console.WriteLine("Enter the text through which you wish to search:");
      Str = Console.ReadLine();
      Console.WriteLine("Enter the word you want to count:");
      Word = Console.ReadLine();
      Console.WriteLine("Case sensitive? [Y/N]");
      CaseSensitive = (Console.ReadLine().ToLower() == "y");
      int matches = Matches();
      if (matches == 1)
      {
        Console.WriteLine("1 match found");
      }
      else
      {
        Console.WriteLine($"{matches} matches found");
      }
    }
    public int Matches()
    {
      if (!Validate())
      {
        return 0;
      }

      if (!CaseSensitive)
      {
        return CaseInsensitiveMatches();
      }

      int matches = 0;
      string[] words = Str.Split(" ");
      foreach (string word in words)
      {
        if (RemovePunctuation(word) == Word || word == Word)
        {
          matches++;
        }
      }
      return matches;
    }

    public int CaseInsensitiveMatches()
    {
      int matches = 0;
      string[] words = Str.Split(" ");
      foreach (string word in words)
      {
        if (RemovePunctuation(word.ToLower()) == Word.ToLower() || word.ToLower() == Word.ToLower())
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
      if (output != "" && !Char.IsLetterOrDigit(output[0]))
      {
        output = output.Substring(1);
        output = RemovePunctuation(output);
      }

      //recursively remove suffixed punctuation
      if (output != "" && !Char.IsLetterOrDigit(output[output.Length - 1]))
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
        Console.WriteLine("One of your search terms was left empty.");
        return false;
      }
      return true;
    }
  }
}