namespace aoc.D01
{
  public static class Calibrator
  {
    public static int GetSumOfCalibrationValues(String[] lines, bool isPartII = false)
    {
      int sum = 0;

      foreach(String line in lines)      
        sum += GetCalibrationValue(line, isPartII);
      
      return sum;
    }

    private static int GetCalibrationValue(string s, bool isPartII = false)
    {
      string lhs, rhs;

      if (isPartII) {
        lhs = GetFirstValueOfInterest_II(s);
        s = new string(s.Reverse().ToArray());
        rhs = GetFirstValueOfInterest_II(s);
      }
      else {
        lhs = GetFirstValueOfInterest(s);
        s = new string(s.Reverse().ToArray());
        rhs = GetFirstValueOfInterest(s);
      }

      return int.Parse(lhs + rhs);
    }

    private static string GetFirstValueOfInterest(string s)
    {
      string answer = "";
      string[] values = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9"};

      for (int i = 0; i < s.Length; i++)
      {
        string sub = s.Substring(i);

        foreach (var v in values) {
          if (sub.StartsWith(v)) {
            answer = v;
            break;
          }
        }

        if (answer.Length > 0)
          break;
      }

      return answer;
    }

    private static string GetFirstValueOfInterest_II(string s)
    {
      string answer = "";
      string[] values = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9",
                          "one", "two", "three", "four", "five", "six", "seven", "eight", "nine",
                          "eno", "owt", "eerht", "ruof", "evif", "xis", "neves", "thgie", "enin" };

      for (int i = 0; i < s.Length; i++) {
        string sub = s.Substring(i);

        foreach (var v in values) {
          if(sub.StartsWith(v)) {
            answer = GetDigit(v);
            break;          
          }
        }

        if (answer.Length > 0)
          break;              
      }

      return answer;
    }

    private static string GetDigit(string s)
    {
      return s switch
      {
        "0" => "0",
        "1" => "1",
        "2" => "2",
        "3" => "3",
        "4" => "4",
        "5" => "5",
        "6" => "6",
        "7" => "7",
        "8" => "8",
        "9" => "9",
        "one" => "1",
        "two" => "2",
        "three" => "3",
        "four" => "4",
        "five" => "5",
        "six" => "6",
        "seven" => "7",
        "eight" => "8",
        "nine" => "9",
        "eno" => "1",
        "owt" => "2",
        "eerht" => "3",
        "ruof" => "4",
        "evif" => "5",
        "xis" => "6",
        "neves" => "7",
        "thgie" => "8",
        "enin" => "9",
        _ => throw new Exception("should not happen!"),
      };
    }
  }
}
