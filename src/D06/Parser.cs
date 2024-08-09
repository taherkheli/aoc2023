namespace aoc.D06
{
  public static class Parser
  {
    public static long Parse(string path, bool isPartII = false)
    {
      var lines = File.ReadAllLines(path);

      if (isPartII)
      {
        var time = long.Parse(lines[0].Split(':', StringSplitOptions.TrimEntries)[1].Replace(" ", ""));
        var distance = long.Parse(lines[1].Split(':', StringSplitOptions.TrimEntries)[1].Replace(" ", ""));
        long waysToWin = 0;

        for (long j = 1; j < time; j++)
          if (((time - j) * j) > distance)
            waysToWin++;

        return waysToWin;
      }
      else
      {
        long result = 1;
        var timesArray = lines[0].Split(':', StringSplitOptions.TrimEntries)[1].Split(' ', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
        var distancesArray = lines[1].Split(':', StringSplitOptions.TrimEntries)[1].Split(' ', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
        var length = timesArray.Length;
        int[] times = new int[length];
        int[] distances = new int[length];

        for (int i = 0; i < length; i++)
        {
          times[i] = int.Parse(timesArray[i]);
          distances[i] = int.Parse(distancesArray[i]);
        }

        for (int i = 0; i < length; i++)
        {
          int waysToWin = 0;

          for (int j = 1; j < times[i]; j++)
            if (((times[i] - j) * j) > distances[i])
              waysToWin++;

          result *= waysToWin;
        }

        return result;
      }
    }
  }
}
