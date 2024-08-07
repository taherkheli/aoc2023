using aoc.D04;
using Xunit;

namespace aoc.test.D04
{
  public class TC01
  {
    [Theory]
    [InlineData(13, "initial.txt")]
    [InlineData(18519, "input.txt")]
    public void D4test1(int expected, string input)
    {
      var deck = Parser.Parse(@"./D04/" + input);
      var actual = deck.SolvePartI();
      Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(30, "initial.txt")]
    [InlineData(11787590, "input.txt")]
    public void D4test2(int expected, string input)
    {
      var deck = Parser.Parse(@"./D04/" + input);
      var actual = deck.SolvePartII();
      Assert.Equal(expected, actual);
    }
  }
}