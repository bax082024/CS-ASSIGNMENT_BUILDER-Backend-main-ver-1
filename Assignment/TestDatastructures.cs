using System.Xml.Serialization;
using C_ASSIGNMENT_BUILDER.Engine.AssignmentBuilder;
using Microsoft.VisualBasic;
using Xunit;

public class TestDatastructures : AssignmentBase
{

    Datastructures datastructures = new Datastructures()
    {
        Strings = [],
        Integers = [],
        Doubles = [],
        Strings2d = [],
        Doubles2d = [],
    };


    [Assignment(1)]
    public void ShouldBeStringArray()
    {
        Assert.Equal(datastructures.Strings, new string[0]);
    }
    [Assignment(2)]
    public void ShouldBeIntArray()
    {
        Assert.Equal(datastructures.Integers, new int[0]);
    }
    [Assignment(3)]
    public void ShouldBeDoubleArray()
    {
        Assert.Equal(datastructures.Doubles, new double[0]);
    }
    [Assignment(4)]
    public void ShouldBeBooleanArray()
    {
        datastructures.Booleans = new bool[2]; // skulle dette være måten å gjøre det på hele veien tro?
        Assert.Equal(datastructures.Booleans, new bool[2]);
    }
    [Assignment(5)]
    public void ShouldBe2DStringArray()
    {
        Assert.Equal(datastructures.Strings2d, new string[0][]);
    }
    [Assignment(6)]
    public void ShouldBe2DIntArray()
    {
        datastructures.Integers2d = new int[1][];
        Assert.Equal(datastructures.Integers2d, new int[1][]);
    }
    [Assignment(7)]
    public void ShouldBe2DArrayOfDoubles()
    {
        Assert.Equal(datastructures.Doubles2d, new double[0][]);
    }
    [Assignment(8)]
    public void ShouldBeListOfStrings()
    {
        datastructures.StringsList = new List<string>{};
        Assert.Equal(new List<string>(), datastructures.StringsList);
    }
    [Assignment(9)]
    public void ShouldBeDictionaryOfIntAndStrings()
    {
        datastructures.KeyValuePairs = new Dictionary<int, string>{};
        Assert.Equal(new Dictionary<int, string>(), datastructures.KeyValuePairs);
    }
}