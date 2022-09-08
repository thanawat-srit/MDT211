namespace Test_HW1;

public class UnitTest1
{
    [Fact]
    public void Test_Trade1000()
    {
        double x = 5400.25;
        double Amoney = MoneyTrader.Trade1000(ref x);
        Assert.Equal(Amoney,5);
    }
    
    [Fact]
    public void Test_Trade500()
    {
        double x = 5400.25;
        double Amoney = MoneyTrader.Trade500(ref x);
        Assert.Equal(Amoney,10);
    }

    [Fact]
    public void Test_Trade100()
    {
        double x = 5400.25;
        double Amoney = MoneyTrader.Trade100(ref x);
        Assert.Equal(Amoney,54);
    }

    [Fact]
    public void Test_Trade50()
    {
        double x = 5400.25;
        double Amoney = MoneyTrader.Trade50(ref x);
        Assert.Equal(Amoney,108);
    }

    [Fact]
    public void Test_Trade20()
    {
        double x = 5400.25;
        double Amoney = MoneyTrader.Trade20(ref x);
        Assert.Equal(Amoney,270);
    }

    [Fact]
    public void Test_Trade10()
    {
        double x = 5400.25;
        double Amoney = MoneyTrader.Trade10(ref x);
        Assert.Equal(Amoney,540);
    }

    [Fact]
    public void Test_Trade5()
    {
        double x = 5400.25;
        double Amoney = MoneyTrader.Trade5(ref x);
        Assert.Equal(Amoney,1080);
    }

    [Fact]
    public void Test_Trade2()
    {
        double x = 5400.25;
        double Amoney = MoneyTrader.Trade2(ref x);
        Assert.Equal(Amoney,2700);
    }

    [Fact]
    public void Test_Trade1()
    {
        double x = 5400.25;
        double Amoney = MoneyTrader.Trade1(ref x);
        Assert.Equal(Amoney,5400);
    }

    [Fact]
    public void Test_Trade050()
    {
        double x = 5400.25;
        double Amoney = MoneyTrader.Trade050(ref x);
        Assert.Equal(Amoney,10800);
    }

    [Fact]
    public void Test_Trade025()
    {
        double x = 5400.25;
        double Amoney = MoneyTrader.Trade025(ref x);
        Assert.Equal(Amoney,21601);
    }
}