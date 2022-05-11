using System;

namespace FirstorLast
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kusib kasutajal sisestada ees-ja perekonnanime
            //programm kontrollib andmete pikkust
            //programm kuvab kumb nendest on pikem, kas ees- voi perekonnanimi


            Console.WriteLine("Sisesta oma eesnimi:");
            string firstName = Console.ReadLine();
            

            Console.WriteLine("Sisesta oma perekonnanimi:");
            string secondName = Console.ReadLine();

            int firstNameLength = firstName.Length;
            int secondNameLenght = secondName.Length;
            Console.WriteLine($"Sinu eesnimes on{firstName.Length} sumbolit ja sinu perekonna nimi on {secondName.Length}.");


            if (firstNameLength > secondNameLenght)
            {
                Console.WriteLine("Sinu nimi on pikem kui sinu perekonnanimi.");
            }
            else if (firstNameLength< secondNameLenght)
            {
                Console.WriteLine("Sinu perekonnanimi on pikem kui sinu nimi.");

            }

            else if (firstNameLength == secondNameLenght){
                Console.WriteLine("Sinu perekonnanimes ja nimes on samapalju sumboleid.");

            }
                    
                
            

        }
    }
}
