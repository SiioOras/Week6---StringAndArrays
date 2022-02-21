using System;

namespace FirstOrLastNew
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajalt sisestada ees-ja perekonnanime;
            //programm kontrollib andmete pikkust eraldi;
            //programm kuvab, kumb neist on pikem, kas ees- või perekonnanimi;

            Console.WriteLine("Sisesta oma eesnimi:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Sisesta oma perekonnanimi:");
            string lastName = Console.ReadLine();

            int firstNameLenght = firstName.Length;
            int lastNameLenght = lastName.Length;
            
            Console.WriteLine($"Sinu eesnimes on {firstNameLenght} sümbolit ja perekonnanimes on {lastNameLenght} sümbolit.");
        }
    }
}
