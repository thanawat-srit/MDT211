public class ShopM
{
    private string ShopName;
    private string Num;
    private string OwnerName;
    private double Value;
    

    public void InputInformation(){
        Console.Write("Please input Name: ");
        this.ShopName = Console.ReadLine();
        Console.Write("Please input Number: ");
        this.Num = Console.ReadLine();
        Console.Write("Please input Owner Name: ");
        this.OwnerName = Console.ReadLine();
        Console.Write("Please input Registered Value: ");
        this.Value = double.Parse(Console.ReadLine());
    }

    

    public void PrintShopInformation()
    {
        Console.WriteLine("----------Shop Information----------");
        Console.WriteLine("Name: {0}", this.ShopName);
        Console.WriteLine("Number: {0}", this.Num);
        Console.WriteLine("Owner Name: {0}", this.OwnerName);
        Console.WriteLine("Registered Value: {0}", this.Value);
        Console.WriteLine("------------------------------------");
    }
}