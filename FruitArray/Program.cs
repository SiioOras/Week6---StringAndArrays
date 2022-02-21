using System;

namespace FruitArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm ennustab, mis puuvilja kasutaja sööb;

            //string[] fruit = new string[5];
            string[] fruit = new string[5] {"an apple", "a banana", "a lemon", "an orange", "some grapes"};

            //Console.WriteLine(fruit[0]); NII on ÜKS võimalus
            //Console.WriteLine(fruit[1]);
            //... jne

            //Console.WriteLine("Enter a number from 0 to 4:"); NII on TEINE võimalus
            //int userNumber = Convert.ToInt32(Console.ReadLine());

            Random rnd = new Random();
            int userNumber = rnd.Next(0, fruit.Length);

            Console.WriteLine($"Today you will have {fruit[userNumber]}");

        }
    }
}
