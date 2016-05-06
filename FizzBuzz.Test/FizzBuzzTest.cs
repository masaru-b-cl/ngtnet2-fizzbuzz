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
      var fizzBuzzer = new FizzBuzzer();

      fizzBuzzer.Say(1).Is("1");
    }

    [TestMethod]
    public void 引数が2の場合文字列で2を返す()
    {
      var fizzBuzzer = new FizzBuzzer();

      fizzBuzzer.Say(2).Is("2");
    }
  }
}
