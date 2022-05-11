using System;

namespace HelloWorldreverse
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab laused "Hello, world!" tagurpidi

            Console.WriteLine("Sisesta lause 'Hello, world!'");
            string thisSent = Console.ReadLine();


            for (int i = thisSent.Length - 1; i >= 0; i--)
            {
                Console.Write(thisSent[i]);
            }
        }
    }
}
