using System;

namespace StringAndArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajalt sisestada eesnime;
            //programm kuvab kasutaja eesnime pikkust;

            Console.WriteLine("Sisesta eesnimi:");
            string firstName = Console.ReadLine();

            int firstNameLenght = firstName.Length;
            Console.WriteLine($"Sinu eesnimes on {firstNameLenght} sümbolit.");


        }
    }
}
