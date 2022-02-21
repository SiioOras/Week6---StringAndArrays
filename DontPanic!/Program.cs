using System;

namespace DontPanic_
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm asendab kõik 'o' tähed lauses "Don´t panic!" 0-ga (nulliga);
            //programm asendab kõik 'a' tähed samas lauses nr 4-ga.

            string dontPanic = "Don't panic!";

            dontPanic = dontPanic.Replace('o', '0');
            dontPanic = dontPanic.Replace('a', '4');

            Console.WriteLine(dontPanic);
        }
    }
}
