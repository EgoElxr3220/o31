internal class Program
{
    private static void Main(string[] args)
    {
        List<string> names = new() { "mage", "warrior", "rogue" };
        names.Select(x => x.ToUpper()).ToList();
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
        var nameLength = names.Select(y => y.Count()).ToList();
        
        foreach (int nameCount in nameLength)
        {
            Console.WriteLine(nameCount);
        }
    }
}