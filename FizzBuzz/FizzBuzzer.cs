using System;

namespace FizzBuzz
{
  public class FizzBuzzer
  {
    public FizzBuzzer()
    {
    }

    public string Say(int number)
    {
      if (number % 3 == 0)
      {
        return "Fizz";
      }

      return $"{number}";
    }
  }
}