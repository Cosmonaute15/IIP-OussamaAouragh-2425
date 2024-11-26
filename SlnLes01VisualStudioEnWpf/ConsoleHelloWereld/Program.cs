namespace ConsoleHelloWereld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Hallo, Wereld! ");
            Console.Write("Hoe heet je: ");
            string naam = Console.ReadLine();
            Console.WriteLine(@$"Aangename kennismaking, {naam}
druk een toets om verder te gaan...");
        }   
    }
}
