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
    public void 引数が正の数の場合文字列でその数を返す()
    {
      fizzBuzzer.Say(1).Is("1");
    }
  }
}
