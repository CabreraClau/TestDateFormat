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
        string actualDate = DateFormatter.ChangeFormat(inputDate);
        
        
        Assert.AreEqual(ExpectDate, actualDate);
    }

    public void Test2()
    {
        const string testDate = "10/11/1997";
        const string expect = "1997-11-10";
        Console.WriteLine($"{testDate} se convierte a {DateFormatter.ChangeFormat(testDate)}");
        Assert.Pass();
        Assert.AreEqual(expect,testDate);
    }

    public void Test3()
    {
        const string testDate = "";
        const string expect = "";
        Console.WriteLine($"{testDate} se convierte a {DateFormatter.ChangeFormat(testDate)}");
        Assert.Pass();
        Assert.AreEqual(expect,testDate);
    }
}