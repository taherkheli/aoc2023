namespace aoc.D01
{
  public static class Calibrator
  {
    public static int GetSumOfCalibrationValues(String[] lines)
    {
      int sum = 0;

      foreach(String line in lines)      
        sum += GetCalibrationValue(line);
      
      return sum;
    }


    private static int GetCalibrationValue(string s)
    {
      char lhs = '!';
      char rhs = '!';
      
      for (int i = 0; i < s.Length; i++)
      {
        if (((int)s[i] > 47) && ((int)s[i] < 58))  // '0'=48; '9'=57
        {
          lhs = s[i];
          break;
        }
      }

      for (int i = s.Length - 1 ; i > -1; i--)
      {
        if (((int)s[i] > 47) && ((int)s[i] < 58))
        {
          rhs = s[i];
          break;
        }
      }

      return int.Parse(String.Join("", new char[] { lhs, rhs }));
    }
  }
}
