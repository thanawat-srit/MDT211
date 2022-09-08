class Program
{
    static void Main(string[] args)
    {
        ShopM MediaS = new ShopM();
        MediaS.InputInformation();
        MediaS.PrintShopInformation();
        MoneyTrader Trade = new MoneyTrader();
        Trade.IfMoneyPassToPrint();
    }
}