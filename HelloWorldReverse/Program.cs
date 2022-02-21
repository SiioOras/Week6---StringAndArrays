using System;

namespace HelloWorldReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab lauset "Hello, World!" tagurpidi;

            //Console.WriteLine("Sisesta sõnapaar 'Hello, World!'");
            //string wordPair = Console.ReadLine();
            
            // proovisin teha nii, et oleks kohe valetpidi, ilma midagi ise sisestamata

            string wordPair = "Hello, World!";

            for (int i = wordPair.Length - 1; i >= 0; i--)
            {
                Console.Write(wordPair[i]);
            }
        }
    }
}
