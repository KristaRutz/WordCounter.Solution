using System;
using WordCounter.Models;

namespace WordCounter
{
  public class Program
  {
    public static void Main()
    {
      RepeatCounter counter = new RepeatCounter();
      Console.WriteLine("Enter the text through which you wish to search:");
      counter.Str = Console.ReadLine();
      Console.WriteLine("Enter the word you want to count:");
      counter.Word = Console.ReadLine();
      Console.WriteLine($"Your search returns ({counter.Matches()}) matches");
      Console.WriteLine("Press 'Enter' to perform a new search");
      if (Console.ReadLine() == "")
      {
        Main();
      }
    }
  }
}