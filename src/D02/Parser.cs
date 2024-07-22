namespace aoc.D02
{
  public static class Parser
  {
    public static int Parse(string path, bool isPartII = false)
    {
      var lines = File.ReadAllLines(path);
      int sum = 0;
      int power = 0;

      for (int i = 0; i < lines.Length; i++)    
      { 
        var game = new Game(GetTurns(lines[i]));
        power += game.Power; 

        if (game.Possible)        
          sum += i + 1;         //game id = i + 1
      }

      if (isPartII)
        return power;
      else 
        return sum;
    }

    private static Turn[] GetTurns(string s)
    {
      var s_array = s.Split(':', StringSplitOptions.TrimEntries);  // discard game part
      s = s_array[1];
      var turns = s.Split(';', StringSplitOptions.TrimEntries);  // retrieve number of turns in this game

      var result = new Turn[turns.Length];

      for (int i = 0; i < turns.Length; i++)
      {
        var configuration = turns[i].Split(',', StringSplitOptions.TrimEntries);
        int reds = 0;
        int greens = 0;
        int blues = 0;

        foreach (var c in configuration)
        {
          var temp = c.Split(' ', StringSplitOptions.TrimEntries);
          var color = temp[1];
          var num = int.Parse(temp[0]);

          switch (color)
          {
            case "red":
              reds = num;
              break;
            case "green":
              greens = num;
              break;
            case "blue":
              blues = num;
              break;
            default:
              throw new Exception("Should not happen!");
          }
        }

        result[i] = new Turn(reds, blues, greens);
      }

      return result;
    }

  }
}