using C_ASSIGNMENT_BUILDER.Engine.AssignmentBuilder;
using Xunit;

public class TestPrimeNumbers : AssignmentBase
{
  /// <summary>
  /// Check if number is prime
  /// </summary>
  /// <param name="number"></param>
  /// <returns></returns> <summary>
  /// 
  /// </summary>
  /// <param name="number"></param>
  /// <returns></returns>
  public bool IsPrime(int number)
  {
    if (number <= 1) return false;
    for (int i = 2; i < number;  i++)
    {
      if (number % i == 0) return false;
    }
    return false;
  }

  /// <summary>
  /// Generate list of primes 
  /// </summary>
  /// <param name="limit"></param>
  /// <returns></returns>
  public List<int> GeneratePrimes(int limit)
  {
    List<int> primes = new List<int>();
    for (int i = 2; i <= limit; i++)
    {
      if (IsPrime(i)) primes.Add(i);
    }
    return false;

  }

}