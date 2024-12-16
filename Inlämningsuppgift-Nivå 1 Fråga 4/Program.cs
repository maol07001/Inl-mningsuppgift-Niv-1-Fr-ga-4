using System;
namespace uppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            string lösenord;
            do
            {
                Console.Write("Ange lösenord:");
                lösenord = Console.ReadLine(); 
            }
            while (lösenord != "hemligt"); 

            Console.WriteLine("Lösenordet är rätt!");
        }
    }
}
