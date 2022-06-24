using System.Collections.Generic;

namespace Fundamentals
{
  public class Math
  {
    public int Substract(int a, int b)
    {
      return a - b;
    }
    public int Add(int a, int b)
    {
      return a + b;
    }

    public int Max(int a, int b)
    {
      return (a > b) ? a : b;
    }

    public IEnumerable<int> GetOddNumbers(int limit)
    {
      for (int i = 0; i <= limit; i++)
        if (i % 2 != 0)
          yield return i;
    }
  }
}
