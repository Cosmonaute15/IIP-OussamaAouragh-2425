namespace ConsoleGangsterName
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
            Console.WriteLine(@"************************
| GANGSTA NAME BUILDER |
************************");
            Console.Write("Give the first name of any Disney character: ");
            string naam = Console.ReadLine();
            Console.Write("Give any workbench tool: ");
            string tool = Console.ReadLine();
            Console.Write("What is your last name: ");
            string lastname = Console.ReadLine();

            Console.Write($"Your gangsta name: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"{naam} 'the {tool}' {lastname}");
        }   
    }
}
