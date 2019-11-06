public class Program
{
    public static void Main()
    {
        string pangram = "The quick brown fox jumps over the lazy dog";

        string[] pangramArray = pangram.Split(' ');

        string[] reversePangramArray = new string[pangramArray.Length];

        for (int i = 0; i < pangramArray.Length; i++)
        {
            char[] wordArray = pangramArray[i].ToCharArray();
            Array.Reverse(wordArray);
            reversePangramArray[i] = new String(wordArray);
        }

        string result = String.Join(" ", reversePangramArray);

        Console.WriteLine(result);
    }
}