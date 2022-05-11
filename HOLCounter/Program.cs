using System;

namespace HOLCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab konsoolis mitu 'h', 'o' ja 'l' t'hte on lauses "Hello World"


            Console.WriteLine("Type'Hello world'");
            string thisSent = Console.ReadLine().ToLower();


            Console.WriteLine(thisSent);


            int hCounter = 0;
            int oCounter = 0;
            int lCounter = 0;


            for (int i = 0; i < thisSent.Length; i++)
            {
                if (thisSent[i] == 'h')
                {
                    hCounter++;
                }          
            }


            for (int i = 0; i < thisSent.Length; i++)
            {
                if (thisSent[i] == 'o')
                {
                    oCounter++;
                }
                        
            }

            for (int i = 0; i < thisSent.Length; i++)
            {
                if (thisSent[i] == 'l')
                {
                    lCounter++;
                }
            }

            if(hCounter == 1)
            {
                Console.WriteLine($"Selles lauses on {hCounter} 'h' taht");
            }

            if (hCounter != 1)
            {
                Console.WriteLine($"Selles lauses on {hCounter} 'h' tahte");
            }


            if (oCounter == 1)
            {
                Console.WriteLine($"Selles lauses on {oCounter} 'o' taht");
            }

            if (oCounter != 1)
            {
                Console.WriteLine($"Selles lauses on {oCounter} 'o' tahte");
            }

            if (lCounter == 1)
            {
                Console.WriteLine($"Selles lauses on {lCounter} 'l' taht");
            }

            if (lCounter != 1)
            {
                Console.WriteLine($"Selles lauses on {lCounter} 'l' tahte");
            }

        }
    }
}
