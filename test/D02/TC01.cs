using aoc.D02;
using Xunit;

namespace aoc.test.D02
{
  public class TC01
  {
    [Theory]
    [InlineData(8, "initial.txt", false)]
    [InlineData(2237, "input.txt", false)]
    [InlineData(2286, "initial.txt", true)]
    [InlineData(66681, "input.txt", true)]
    public void D2test(int expected, string input, bool isPartII)
    {
      var actual = Parser.Parse(@"./D02/" + input, isPartII);
      Assert.Equal(expected, actual);
    }
  }
}