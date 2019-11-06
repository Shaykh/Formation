public class Program
{
    public static void Main()
    {
        System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CreateSpecificCulture("fr-CI");
        System.Threading.Thread.CurrentThread.CurrentCulture = culture;
        // Mise en forme composite
        string first = "Hello";
        string second = "World";
        Console.WriteLine("{1} {0}!", first, second);
        Console.WriteLine("{0} {0} {0}!", first, second);
        // Interpolation de chaîne
        string first = "Hello";
        string second = "World";
        Console.WriteLine($"{first} {second}!");
        Console.WriteLine($"{second} {first}!");
        Console.WriteLine($"{first} {first} {first}!");
        // Mise en forme de valeurs monétaires
        decimal price = 123.45m;
        int discount = 50;
        Console.WriteLine($"Prix: {price:C} (Réduction {discount:C})");
        // Mise en forme des nombres
        decimal measurement = 123456.78912m;
        Console.WriteLine($"Mesure: {measurement:N} unités");
        Console.WriteLine($"Mesure: {measurement:N4} unités");
        // Mise en forme des pourcentages
        decimal tax = 10.36785m;
        Console.WriteLine($"Taux taxe brute: {tax:P2}");
        tax = .36785m;
        Console.WriteLine($"Taux taxe révisé: {tax:P2}");
    }
}