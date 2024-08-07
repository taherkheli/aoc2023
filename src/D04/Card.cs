namespace aoc.D04
{
  public class Card
  {
    private int _id;
    private int[][] _numbers;

    public Card(int id, int[][] numbers)
    {
      _id = id;
      _numbers = numbers;
    }

    public int ID { get { return _id; } }
    
    public int[][] Numbers { get { return _numbers; } }

  }
}
