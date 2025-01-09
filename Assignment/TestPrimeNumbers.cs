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

}