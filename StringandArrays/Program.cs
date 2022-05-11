using System;

namespace StringandArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kusib kasutajal sisestada eesnime
            //programm kuvab kasutaja eesnime pikust

            Console.WriteLine("Sisesta oma eesnimi:");
            string firstName = Console.ReadLine();

            int firstNameLength = firstName.Length;
            Console.WriteLine($"Sinu eesnimes on{firstName.Length} sumbolit.");

        }
    }
}
