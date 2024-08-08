namespace aoc.D04
{
  public class Deck
  {
    private List<Card> _cards;

    public Deck(List<Card> cards)
    {
      _cards = cards;
    }

    public List<Card>Cards { get { return _cards; } }

    public int SolvePartI()
    {
      int sum = 0;

      foreach (var card in _cards)
      {
        int points = 0;
        var intersection = card.Numbers[0].Intersect(card.Numbers[1]).ToArray();

        if (intersection.Length > 0)
        {
          points = 1;

          for (int i = 1; i < intersection.Length; i++)  //start at index 1 as first match counts 1 point only 
            points = 2 * points;
        }

        sum += points;
      }

      return sum;
    }

    public int SolvePartII()
    {
      int[] matchCounts = new int[_cards.Count];
      List<Card> copies = new List<Card>();

      for (int i = 0; i < _cards.Count; i++)
      {
        var intersection = _cards[i].Numbers[0].Intersect(_cards[i].Numbers[1]).ToArray();
        matchCounts[i] = intersection.Length;
      }

      for (int i = 0; i < matchCounts.Length; i++)
      {
        int id = i + 1;

        // find instance count of this id
        var currentCount = _cards.Where(c => c.ID == id).ToList().Count;

        for (int j = 0; j < currentCount; j++)  //repeat for each instance        
        {
          for (int k = id + 1; k < id + matchCounts[i] + 1; k++)  //create copies with correct ID
          {
            var first = _cards.First(c => c.ID == k);
            copies.Add(new Card(k, first.Numbers));
          }
        }

        // update cards by appending copies and reset copies
        _cards.AddRange(copies);
        copies = new List<Card>();
      }

      return _cards.Count;
    }
  }
}
