using aoc.D01;
using Xunit;

namespace aoc.test.D01
{
  public class TC01
  {
    [Fact]
    public void InitialI()
    {
      int expected = 142;
      var lines = Parser.Parse(@"./D01/initial.txt");
      var actual = Calibrator.GetSumOfCalibrationValues(lines);
      Assert.Equal(expected, actual);
    }

    [Fact]
    public void PartI()
    {
      int expected = 56465;
      var lines = Parser.Parse(@"./D01/input.txt");
      var actual = Calibrator.GetSumOfCalibrationValues(lines);
      Assert.Equal(expected, actual);
    }

    //[Fact]
    //public void InitialII()
    //{
    //  int expected = 45000;
    //  var elves = Parser.Parse(@"./D01/initial.txt");
    //  var actual = CalorieCounter.GetMaxCaloriesTop3(elves);
    //  Assert.Equal(expected, actual);
    //}

    //[Fact]
    //public void PartII()
    //{
    //  int expected = 203905;
    //  var elves = Parser.Parse(@"./D01/input.txt");
    //  var actual = CalorieCounter.GetMaxCaloriesTop3(elves);
    //  Assert.Equal(expected, actual);
    //}
  }
}