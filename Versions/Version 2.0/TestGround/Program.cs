namespace TestGround
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
            Random cube = new Random();
            int Ergebnis = cube.Next(1, 100);
            Console.WriteLine(Ergebnis);
        }
    }
}