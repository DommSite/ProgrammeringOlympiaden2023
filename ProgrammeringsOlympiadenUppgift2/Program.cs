using System;

namespace ProgrammeringsOlympiadenUppgift2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool looping = true;
            long N = 0;
            while (looping==true)
            {
                Console.WriteLine("N?");
                try
                {
                    N = long.Parse(Console.ReadLine());
                        looping = false;
                }
                catch
                {
                    Console.WriteLine("Du måste skriva ett tal");
                }
            }
            
            
            long[] antaltreiga = new long[N];
            int b = 0;
            for (long i = 0; i < N; i++)
            {
                try
                {
                    long treigatest = (i * i * i) + (3 * (i * i)) + (2 * i);
                    if (treigatest < N) 
                    {
                        antaltreiga[b] = treigatest;
                        b++;
                    }
                }
                catch
                {

                }
            }
            int x = 0;
            for(int i = 0; i < antaltreiga.Length; i++)
            {
                if (antaltreiga[i] != 0)
                {
                    x = x + 1;
                }
            }
            Console.WriteLine("Den totala mängden treiga tal är: " + x);
            for (int i = 0;i < antaltreiga.Length;i++) 
            {
                if (antaltreiga[i] != 0)
                {
                    Console.WriteLine(antaltreiga[i]);
                }
                
            }
        }
    }
}
