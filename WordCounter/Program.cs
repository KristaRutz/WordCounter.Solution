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
      int matches = counter.Matches();
      if (matches == 1)
      {
        Console.WriteLine("1 match found");
      }
      else
      {
        Console.WriteLine($"{matches} matches found");
      }
      Console.WriteLine("Press 'Enter' to perform a new search");
      if (Console.ReadLine() == "")
      {
        Main();
      }
    }
  }
}