using aoc.D06;
using Xunit;

namespace aoc.test.D06
{
  public class TC01
  {
    [Theory]
    [InlineData(288, "initial.txt")]
    [InlineData(3317888, "input.txt")]
    [InlineData(71503, "initial.txt", true)]
    [InlineData(24655068, "input.txt", true)]
    public void D6test1(long expected, string input, bool isPartII = false)
    {
      var actual = Parser.Parse(@"./D06/" + input, isPartII);
      Assert.Equal(expected, actual);
    }
  }
}