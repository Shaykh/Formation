public class 
{
    public static void Main()
    {
        System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CreateSpecificCulture("fr-CI");
        System.Threading.Thread.CurrentThread.CurrentCulture = culture;

        decimal price = 123.45m;
        int discount = 50;
        Console.WriteLine($"Prix: {price:C} (Réduction {discount:C})");

        decimal measurement = 123456.78912m;
        Console.WriteLine($"Mesure: {measurement:N} unités");
        Console.WriteLine($"Mesure: {measurement:N4} unités");

        decimal tax = 10.36785m;
        Console.WriteLine($"Taux taxe brute: {tax:P2}");
        tax = .36785m;
        Console.WriteLine($"Taux taxe révisé: {tax:P2}");
    }
}