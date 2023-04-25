using System;

namespace Library.Tests;

public class DateFormatterTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestChangeFormat()
    {
        const string InputDate = "10/11/1997";
        const string ExpectDate = "1997-11-10";
        string actualDate = DateFormatter.ChangeFormat(InputDate);
        
        
        Assert.AreEqual(ExpectDate, actualDate);
    }
    [Test]
    public void TestlenghtIsValid()
    {
        const string InputDate = "10/11/19977";
        const string ExpectDate = "";
        string actualDate = DateFormatter.ChangeFormat(InputDate);
        
        
        Assert.AreEqual(ExpectDate, actualDate);
    }
    [Test]
    public void TestDayIsValid()
    {
        const string InputDate = "50/51/19977";
        const string ExpectDate = "";
        string actualDate = DateFormatter.ChangeFormat(InputDate);
        
        
        Assert.AreEqual(ExpectDate, actualDate);
    }
}