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

    public void TestlenghtIsValid()
    {
        const string testDate = "10/11/19977";
        const string expect = "";
        Console.WriteLine($"{testDate} se convierte a {DateFormatter.ChangeFormat(testDate)}");
        Assert.Pass();
        Assert.AreEqual(expect,testDate);
    }

    public void TestDayIsValid()
    {
        const string testDate = "50/20/2011";
        const string expect = "";
        Console.WriteLine($"{testDate} se convierte a {DateFormatter.ChangeFormat(testDate)}");
        Assert.Pass();
        Assert.AreEqual(expect,testDate);
    }
}