public class Program
{
    public static void Main()
    {
        System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US");
        System.Threading.Thread.CurrentThread.CurrentCulture = culture;

        string customerName = "Mr. Jones";

        string currentProduct = "Magic Yield";
        int currentShares = 2975000;
        decimal currentReturn = 0.1275m;
        decimal currentProfit = 55000000.0m;

        string newProduct = "Glorious Future";
        decimal newReturn = 0.13125m;
        decimal newProfit = 63000000.0m;

        Console.WriteLine($"Dear {customerName}");
        Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n");

        Console.WriteLine($"Currently, you own {currentShares:N} shares at a return of {currentReturn:P2}.\n");

        Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P2}.  Given your current volume, your potential profit would be {newProfit:C}.\n");

        Console.WriteLine("Here's a quick comparison:\n");

        string comparrisonMessage = "";

        comparrisonMessage += currentProduct.PadRight(18);
        comparrisonMessage += $"{currentReturn:P2}".PadRight(12);
        comparrisonMessage += $"{currentProfit:C}\n";

        comparrisonMessage += newProduct.PadRight(18);
        comparrisonMessage += $"{newReturn:P2}".PadRight(12);
        comparrisonMessage += $"{newProfit:C}";

        Console.WriteLine(comparrisonMessage);
    }
}