namespace aoc.D04
{
  public static class Parser
  {
    public static Deck Parse(string path)
    {
      int[] cardNumbers;
      int[] yourNumbers;
      var lines = File.ReadAllLines(path);
      int index = 1;
      List<Card> cards = new List<Card>();

      foreach (var line in lines)
      {
        var data = line.Split(':', StringSplitOptions.TrimEntries)[1].Split('|', StringSplitOptions.TrimEntries);
        var cardData = data[0].Split(' ', StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);
        var numbersData = data[1].Split(' ', StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);
        cardNumbers = new int[cardData.Length];
        yourNumbers = new int[numbersData.Length];

        for (int i = 0; i < cardNumbers.Length; i++)
          cardNumbers[i] = int.Parse(cardData[i]);

        for (int i = 0; i < yourNumbers.Length; i++)
          yourNumbers[i] = int.Parse(numbersData[i]);

        cards.Add(new Card(index, new int[][] { cardNumbers, yourNumbers }));
        index++;
      }

      return new Deck(cards);
    }
  }
}
