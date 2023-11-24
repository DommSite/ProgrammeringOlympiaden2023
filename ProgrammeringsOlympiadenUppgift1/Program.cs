using System;

namespace ProgrammeringsOlympiadenUppgift1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool looping = false;
            Console.WriteLine("Vilket ord ska upprepas?");
            string ord = Console.ReadLine();
            int upprepningar = 0;
            while (looping == false) 
            {
                try
                {
                    Console.WriteLine("Hur många gånger ska det upprepas?");
                    int antal = int.Parse(Console.ReadLine());
                    if (antal < 10 && antal > 0)
                    {
                        upprepningar = antal;
                        looping = true;
                    }
                    else
                    {
                        Console.WriteLine("Icke giltligt antal, måste vara ett heltal mellan 1 och 9");
                    }
                }
                catch
                {
                    Console.WriteLine("Inte ett giltligt antal, måste vara ett heltal mellan 1 och 9");
                }
            }
            for (int i = 0; i < upprepningar; i++)
            {
                Console.Write(ord);
            }
            Console.ReadKey();
        }
    }
}
