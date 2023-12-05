namespace aoc.D01
{
  public static class Parser
  {
    public static String[] Parse(string path)
    {
      return File.ReadAllLines(path);
    }
  }
}
