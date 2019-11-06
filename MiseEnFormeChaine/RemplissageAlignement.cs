public class Program
{
    public static void Main()
    {
        // Mise en forme de chaînes en les faisant précéder ou suivre d’un espace blanc
        string input = "Pad this";
        Console.WriteLine(input.PadLeft(12));
        Console.WriteLine(input.PadRight(12));
        // Mise en forme de chaînes en les faisant précéder ou suivre d’un caractère
        Console.WriteLine(input.PadLeft(12, '-'));
        Console.WriteLine(input.PadRight(12, '-'));
        // 
        string paymentId = "769";
        string payeeName = "Mr. Stephen Ortega";
        string paymentAmount = "$5,000.00";

        var formattedLine = paymentId.PadRight(6);
        formattedLine += payeeName.PadRight(24);
        formattedLine += paymentAmount.PadLeft(10);

        Console.WriteLine("1234567890123456789012345678901234567890");
        Console.WriteLine(formattedLine);
    }
}