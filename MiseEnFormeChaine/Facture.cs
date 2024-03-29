public class Program
{
    public static void Main()
    {
        System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CreateSpecificCulture("fr-FR");
        System.Threading.Thread.CurrentThread.CurrentCulture = culture;

        int invoiceNumber = 1201;
        decimal productMeasurement = 25.4568m;
        decimal subtotal = 2750.00m;
        decimal taxPercentage = .15825m;
        decimal total = 3185.19m;

        Console.WriteLine($"Invoice Number: {invoiceNumber}");
        Console.WriteLine($"   Measurement: {productMeasurement:N3} mg");
        Console.WriteLine($"     Sub Total: {subtotal:C}");
        Console.WriteLine($"           Tax: {taxPercentage:P2}");
        Console.WriteLine($"     Total Due: {total:C}");
    }
}