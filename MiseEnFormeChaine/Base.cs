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
        // 
        Console.WriteLine(@"   c:\source\repos   
        (this is where your code goes)");
        //
        Console.WriteLine("Generating invoices for customer \"ABC Corp\" ...");
        Console.WriteLine("Invoice: 1021\t\tComplete!");
        Console.WriteLine("Invoice: 1022\t\tComplete!");
        Console.WriteLine("\nOutput Directory:\t");
        Console.WriteLine("c:\\source\\repos");
        Console.Write(@"c:\invoices");

        // Kon'nichiwa World
        Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");

        // To generate Japanese invoices:
        // Nihon no seikyū-sho o seisei suru ni wa:
        Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
        Console.WriteLine(@"c:\invoices\app.exe -j");
        //
        string projectName = "First-Project";
        Console.WriteLine($@"
        C:\Output\{projectName}\Data");
        //
        //
        string projectName = "ACME";
        string englishLocation = $@"c:\Exercise\{ projectName}\data.txt";
        Console.WriteLine($"View English output:\n\t\t{englishLocation}\n");
                    
        string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
        string russianLocation = $@"c:\Exercise\{projectName}\ru-RU\data.txt";
        Console.WriteLine($"{russianMessage}:\n\t\t{russianLocation}\n");
    }
}