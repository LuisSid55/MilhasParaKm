using System;

namespace MilhasParaKm
{
    class Program
    {
        static void Main(string[] args)
        {
            double mi, km = 1.609;
            Console.WriteLine("\n---Milhas para Km---");
            
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("\nDiga em milhas: ");
            mi = Convert.ToDouble(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write($"\nQue eu digo:    {mi * km} Km\n");
            Console.ResetColor();
        }
    }
}
