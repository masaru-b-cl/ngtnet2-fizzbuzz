using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz.Test
{
  [TestClass]
  public class FizzBuzzTest
  {
    [TestMethod]
    public void 引数が1の場合文字列で1を返す()
    {
      // arrange
      var fizzBuzzer = new FizzBuzzer();

      // act
      string result = fizzBuzzer.Say(number: 1);

      // assert
      result.Is("1");
    }
  }
}
