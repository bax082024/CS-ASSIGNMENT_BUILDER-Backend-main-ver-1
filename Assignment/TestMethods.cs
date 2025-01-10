using System.Numerics;
using C_ASSIGNMENT_BUILDER.Engine.AssignmentBuilder;
using Xunit;

public class TestMethods : AssignmentBase
{
    Generics t = new Generics();
    Generics e = new Generics();

    /// <summary>
    /// Return a string
    /// </summary>
    /// <param name="str"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public string StringMethod(string str)
    {
        return str;
    }
    /// <summary>
    /// Return a new string array
    /// </summary>
    /// <param name="arr"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public string[] StringArrayMethod(string[] arr)
    {
        return arr;
    }
    /// <summary>
    /// Return the sum of a + b
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public int AddIntMethod(int a, int b)
    {
        throw new NotImplementedException();
    }
    /// <summary>
    /// Return the sum of a * b
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public double MultiplyDoubleMethod(double a, double b)
    {
        return a + b;
    }
    /// <summary>
    /// Return a list of doubles
    /// </summary>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public List<double> ListDoubleMethod()
    {
        throw new NotImplementedException();
    }
    /// <summary>
    /// Return a single characther
    /// </summary>
    /// <param name="a"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public char CharMethod(char c)
    {
        throw new NotImplementedException();
    }
    /// <summary>
    /// Return a boolean that should be true
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public bool IsNotTrue(bool value)
    {
        throw new NotImplementedException();
    }
    /// <summary>
    /// Return a boolean that should be false
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public bool IsNotFalse(bool value)
    {
        throw new NotImplementedException();
    }
    public List<Generics> GenericTypeMethod(Generics e, Generics t)
    {
        throw new NotImplementedException();
    }
    /// <summary>
    /// Can enter if the age is greater than or equal to 18, 
    /// if age is greater than or equal to 18, return true, else return false
    /// </summary>
    /// <param name="age"></param>
    /// <exception cref="NotImplementedException"></exception>
    public bool CanEnter(int age)
    {
        throw new NotImplementedException();
    }
    /// <summary>
    /// Return a new dictionary with int keys and string values
    /// </summary>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public Dictionary<int, string> DictionaryMethod()
    {
        throw new NotImplementedException("");
    }
    /// <summary>
    /// Return the square of a (a * a)
    /// </summary>
    /// <param name="a"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public double Square(double a)
    {
        throw new NotImplementedException();
    }
    /// <summary>
    /// Return the sum of a / b, make sure that a and b cannot be 0
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public double DivideNumbers(double a, double b)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Return a new file
    /// </summary>
    /// <param name="path"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public string CreateNewFile(string path)
    {
        throw new NotImplementedException();
    }
    /// <summary>
    /// Append text content to an exisiting file
    /// </summary>
    /// <param name="path"></param>
    /// <param name="content"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public string AppendTextContent(string path, string content)
    {
        throw new NotImplementedException();
    }
    /*
    @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
    *****************     TESTS ********************************
    ***************** Do Not edit these methods ****************
    @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
    */
    [Assignment(1)]
    public void TestStringMethod()
    {
        string[] expectedPool = { "Hello, World!", "", "C#", "Programming!" };
        Assert.Equal(expectedPool[0], StringMethod(expectedPool[0]));
        Assert.Equal(expectedPool[1], StringMethod(expectedPool[1]));
        for (int i = 0; i < expectedPool.Length; i++)
        {
            Assert.Equal(expectedPool[i], StringMethod(expectedPool[i]));
            Assert.NotNull(StringMethod(expectedPool[i]));
        }
    }

    [Assignment(2)]
    public void TestStringArrayMethod()
    {
        string[] expected = new string[255];
        Assert.Equal(StringArrayMethod(expected), expected);
    }
    [Assignment(3)]
    public void TestIntAddMethod()
    {
        int[] expected = { 3, 5, 10, 25, -2 };
        Assert.Equal(AddIntMethod(1, 2), expected[0]);
        Assert.Equal(AddIntMethod(3, 2), expected[1]);
        Assert.Equal(AddIntMethod(5, 5), expected[2]);
        Assert.Equal(AddIntMethod(20, 5), expected[3]);
        Assert.Equal(AddIntMethod(-4, 2), expected[4]);
    }
    [Assignment(4)]
    public void TestMultiplyDoubleMethod()
    {
        double[] expected = { 4, 5, 10, 25, 1024 };

        Assert.Equal(MultiplyDoubleMethod(2, 2), expected[0]);
        Assert.Equal(MultiplyDoubleMethod(5, 1), expected[1]);
        Assert.Equal(MultiplyDoubleMethod(10, 1), expected[2]);
        Assert.Equal(MultiplyDoubleMethod(5, 5), expected[3]);
        Assert.Equal(MultiplyDoubleMethod(512, 2), expected[4]);

    }
    [Assignment(5)]
    public void TestIsListOfDoubles()
    {
        Assert.Equal(new List<double>(), ListDoubleMethod());
        Assert.Equivalent(new List<double>(), ListDoubleMethod());
    }
    [Assignment(6)]
    public void TestCharMethod()
    {
        char[] expected = { 'A', 'a', 'B', 'b', 'C', 'c', 'D', 'd' };
        for (int i = 0; i < expected.Length; i++)
        {
            Assert.Equal(CharMethod(expected[i]), expected[i]);
        }
    }
    [Assignment(7)]
    public void TestBooleanMethods()
    {
        bool[] expected = { true, false, false, true, true };
        for (int i = 0; i < expected.Length; i++)
        {
            Assert.Equal(IsNotFalse(expected[i]), expected[i]);
            Assert.Equal(IsNotTrue(expected[i]), expected[i]);
        }
    }
    [Assignment(8)]
    public void TestGenericTypes()
    {
        Assert.Equal(new List<Generics>(), GenericTypeMethod(t, e));
    }
    [Assignment(9)]
    public void TestCanEnter()
    {
        Assert.True(CanEnter(18));
        Assert.False(CanEnter(10));
    }
    [Assignment(10)]
    public void TestDictionary()
    {
        Assert.Equal(new Dictionary<int, string>(), DictionaryMethod());
    }
    [Assignment(11)]
    public void TestSquare()
    {
        for (int i = 2; i < 100; i++)
        {
            Assert.Equal(Double.Pow(i, 2), Square(i));
        }
    }
    [Assignment(12)]
    public void TestDivideNumbers()
    {
        double[] expected = new double[15];
        for (int i = 0; i < expected.Length; i++)
        {
            Assert.Equal(expected[i], DivideNumbers(i, 2));
            Assert.Equal(expected[i], DivideNumbers(expected[i], expected[i]));
            if (DivideNumbers(expected[i], 0) == double.PositiveInfinity || DivideNumbers(expected[i], 0) == double.NegativeInfinity)
            {
                throw new DivideByZeroException();
            }
        }
    }
    [Assignment(13)]
    public void TestCreateFile()
    {
        string filePath = "test_file.txt";
        try
        {
            string result = CreateNewFile(filePath);
            Assert.True(File.Exists(filePath));
            Assert.Equal(filePath, result);
            // if the file is empty, the content within should be a empty string
            Assert.Equal(string.Empty, File.ReadAllText(filePath));
        }
        catch (Exception e)
        {
            Console.WriteLine("Error:", e.Message);
        }
        finally
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
        }
    }
    [Assignment(14)]
    public void TestAppendTextContent()
    {
        string filePath = "test_append.txt";
        string exisitingContent = "Hello, World!";
        string textToAppend = "Hello, World!";
        try
        {
            File.WriteAllText(filePath, exisitingContent);
            string result = AppendTextContent(filePath, textToAppend);
            // check wheter or not the file exists, rather than hardcoding the files we can do this within or I/O error-handler
            Assert.True(File.Exists(filePath));
            Assert.Equal(filePath, result);
            string expectedContent = exisitingContent + textToAppend;
            Assert.Equal(expectedContent, File.ReadAllText(filePath));
        }
        finally
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
        }
    }

    [Assignment(15)]
    public void TestPrimeNumbers()
    {
        List<int> expectedPrimes = new List<int> { 2, 3, 5, 7, 11 };
        List<int> actualPrimes = GeneratePrimes(12);

        Assert.Equal(expectedPrimes, actualPrimes);
    }

    // generate prime numbers
    public List<int> GeneratePrimes(int limit)
    {
        List<int> primes = new List<int>();
        for (int i = 2; i <= limit; i++)
        {
            if (IsPrime(i))
            {
                primes.Add(i);
            }
        }
        return primes;
    }

    // check if number is prime
    private bool IsPrime(int number)
    {
        if (number < 2) return false;
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0) return false;
        }
        return true;
    }

}
