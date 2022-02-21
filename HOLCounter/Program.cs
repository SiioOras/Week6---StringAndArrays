using System;

namespace HOLCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab konsoolis, mitu 'h', 'o' ja 'l' tähte on lauses "Hello World!";

            Console.WriteLine("Sisesta sõnapaar:");
            string twoWords = Console.ReadLine().ToLower();


            int hCounter = 0;
            
            for (int i = 0; i < twoWords.Length; i++)
            {
                if (twoWords[i] == 'h')
                {
                    hCounter++;
                }
            }

            int oCounter = 0;

            for (int i = 0; i < twoWords.Length; i++)
            {
                if (twoWords[i] == 'o')
                {
                    oCounter++;
                }
            }

            int lCounter = 0;
            
            for (int i = 0; i < twoWords.Length; i++)
            {
                if (twoWords[i] == 'l')
                {
                    lCounter++;
                }
            }

            Console.WriteLine($"Sinu sõnapaaris on {hCounter} 'h' tähte, {oCounter} 'o' tähte ja {lCounter} 'l' tähte.");
        }
    }
}
