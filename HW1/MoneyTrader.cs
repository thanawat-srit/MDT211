public class MoneyTrader{
    public double Money;
    public void IfMoneyPassToPrint(){
        Console.Write("Please input money: ");
        this.Money = double.Parse(Console.ReadLine());
        if (this.Money % 0.25 == 0)
        {
            PrintTradeInformation(ref this.Money);
        }
        else
        {
            throw new Exception("Please enter money correctly.");
        }
    }
    public void PrintTradeInformation(ref double CAmoney)
    {
        Console.WriteLine("1000: {0}", Trade1000(ref CAmoney));
        Console.WriteLine("500 : {0}", Trade500(ref CAmoney));
        Console.WriteLine("100 : {0}", Trade100(ref CAmoney));
        Console.WriteLine("50  : {0}", Trade50(ref CAmoney));
        Console.WriteLine("20  : {0}", Trade20(ref CAmoney));
        Console.WriteLine("10  : {0}", Trade10(ref CAmoney));
        Console.WriteLine("5   : {0}", Trade5(ref CAmoney));
        Console.WriteLine("2   : {0}", Trade2(ref CAmoney));
        Console.WriteLine("1   : {0}", Trade1(ref CAmoney));
        Console.WriteLine(".5  : {0}", Trade050(ref CAmoney));
        Console.WriteLine(".25 : {0}", Trade025(ref CAmoney));
    }

    public static double Trade1000(ref double money)
    {
        double i = Math.Floor(money / 1000);
        money -= i * 1000;

        return i;
    }
    public static double Trade500(ref double money)
    {
        double i = Math.Floor(money / 500);
        money -= i * 500;

        return i;
    }
    public static double Trade100(ref double money)
    {
        double i = Math.Floor(money / 100);
        money -= i * 100;

        return i;
    }
    public static double Trade50(ref double money)
    {
        double i = Math.Floor(money / 50);
        money -= i * 50;

        return i;
    }
    public static double Trade20(ref double money)
    {
        double i = Math.Floor(money / 20);
        money -= i * 20;

        return i;
    }
    public static double Trade10(ref double money)
    {
        double i = Math.Floor(money / 10);
        money -= i * 10;

        return i;
    }
    public static double Trade5(ref double money)
    {
        double i = Math.Floor(money / 5);
        money -= i * 5;

        return i;
    }
    public static double Trade2(ref double money)
    {
        double i = Math.Floor(money / 2);
        money -= i * 2;

        return i;
    }
    public static double Trade1(ref double money)
    {
        double i = Math.Floor(money / 1);
        money -= i * 1;

        return i;
    }
    public static double Trade050(ref double money)
    {
        double i = Math.Floor(money / 0.50);
        money -= i * 0.50;

        return i;
    }
    public static double Trade025(ref double money)
    {
        double i = Math.Floor(money / 0.25);
        money -= i * 0.25;

        return i;
    }
}