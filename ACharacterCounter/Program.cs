using System;

namespace ACharacterCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada ees- ja perekonnanime;
            //programm kuvab, mitu A tähte on kasutaja ees- ja perekonnanimes kokku;

            Console.WriteLine("Sisesta oma eesnimi:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Sisesta oma perekonnanimi:");
            string lastName = Console.ReadLine();


            string fullName = $"{firstName}{lastName}".ToLower();

            Console.WriteLine(fullName);
            
            int aCounter = 0;

            for (int i = 0; i < fullName.Length; i++)
            {
                if(fullName[i] == 'a') //char a = 'a';
                {
                    aCounter++;
                }
            }
            if (aCounter != 1)
            {
                Console.WriteLine($"Sinu täisnimes on {aCounter} 'a' tähte.");
            }
            else
            {
                Console.WriteLine($"Sinu täisnimes on {aCounter} 'a' täht.");
            }
        }
    }
}
