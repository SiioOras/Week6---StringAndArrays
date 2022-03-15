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

            if (firstNameLenght>lastNameLenght)
            {
                Console.WriteLine($"Su eesnimi on pikem kui perekonnanimi.");
            }
            else if (firstNameLenght<lastNameLenght)
            {
                Console.WriteLine($"Su perekonnanimi on pikem kui eesnimi.");
            }
            else
            {
                Console.WriteLine($"Su eesnimi ja perekonnanimi on ühepikkused!");
            }
        }
    }
}
