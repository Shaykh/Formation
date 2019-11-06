public class Program
{
    public static void Main()
    {
        string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

        string[] orderSplit = orderStream.Split(',');

        foreach (string order in orderSplit)
        {
            if (order.StartsWith("B"))
            {
                Console.WriteLine(order);
            }
        }
    }
}