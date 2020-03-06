using System;
using WordCounter.Models;

namespace WordCounter
{
  public class Program
  {
    public static void Main()
    {
      RepeatCounter counter = new RepeatCounter();
      counter.NewSearch();
      Console.WriteLine("Press 'Enter' to perform a new search");
      if (Console.ReadLine() == "")
      {
        Main();
      }
    }
  }
}