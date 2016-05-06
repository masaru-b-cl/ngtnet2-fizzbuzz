using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz.Test
{
  [TestClass]
  public class FizzBuzzTest
  {
    private FizzBuzzer fizzBuzzer;

    [TestInitialize]
    public void SetUp()
    {
      fizzBuzzer = new FizzBuzzer();
    }

    [TestMethod]
    public void 引数が1の場合文字列で1を返す()
    {
      fizzBuzzer.Say(1).Is("1");
    }

    [TestMethod]
    public void 引数が2の場合文字列で2を返す()
    {
      fizzBuzzer.Say(2).Is("2");
    }
  }
}
