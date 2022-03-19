using System;

namespace GuessingGameThreeTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhuslikku numbrit 1 kuni 10;
            //kasutaja peab seda numbrit ära arvama;
            //kui kasutaja suutis seda numbrit ära arvata, siis ta on mängu võitnud;
            //kasutajal on kolm katset, kui kasutaja ei ole suutnud kolme katsega numbrit ära arvata, siis mängu võidab arvuti;
            //programm genereerib juhuslikku numbrit ühe korra;

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);
            int i = 0;


            while (i < 3)
            {
                Console.WriteLine("Arva ära genereeritud number 1 kuni 10:"); //cw+double TAB
                int userNumber = Convert.ToInt32(Console.ReadLine());

                if (cpuNumber == userNumber)
                {
                    Console.WriteLine("Sa oled võitnud!");
                    break;
                }
                else
                {
                    i++; //(i = i + 1) == i++
                    Console.WriteLine($"Vale number. {3 - i} katset on jäänud.");
                }

            }

            Console.WriteLine("Kena päeva jätku!");
            Console.ReadLine();

        }
    }
}
