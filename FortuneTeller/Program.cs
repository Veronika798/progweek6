using System;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm ennustab, mis kasutajaga juhtub homme(kasutame randomit)

            string[] predictions = { "won a million", "fall in love", "buy a car", "join the dark side for cookies" };

            Random rnd = new Random();
            int userNumber = rnd.Next(0, predictions.Length);

            Console.WriteLine($"Today you will {predictions[userNumber]}.");
        }
    }
}
