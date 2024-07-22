namespace aoc.D02
{
  public class Game(Turn[] turns)
  {
    private readonly Turn[] _turns = turns;

    public bool Possible => GetPossibility(); 

    public int Power => GetPower();

    private bool GetPossibility()
    {
      return _turns.All(t => t.red < 13 && t.green < 14 && t.blue < 15);
    }

    private int GetPower() 
    {
      int maxRed = 0;
      int maxGreen = 0;
      int maxBlue = 0;

      foreach (var turn in _turns)
      {
        if (turn.red > maxRed)
          maxRed = turn.red;

        if (turn.green > maxGreen)
          maxGreen = turn.green;

        if (turn.blue > maxBlue)
          maxBlue = turn.blue;
      }

      return maxRed * maxGreen * maxBlue;
    }
  }
}
