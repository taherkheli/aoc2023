using aoc.D01;
using Xunit;

namespace aoc.test.D01
{
  public class TC01
  {
    [Theory]
    [InlineData(142, "initial.txt", false)]
    [InlineData(56465, "input.txt", false)]
    [InlineData(281, "initial_2.txt", true)]
    [InlineData(55902, "input.txt", true)]
    public void D1test(int expected, string input, bool isPartII)
    {
      var lines = Parser.Parse(@"./D01/" + input);
      var actual = Calibrator.GetSumOfCalibrationValues(lines, isPartII);
      Assert.Equal(expected, actual);
    }
  }
}