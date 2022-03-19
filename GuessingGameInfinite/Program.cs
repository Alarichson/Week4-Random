using System;

namespace GuessingGameInfinite
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhuslikku numbrit 1 kuni 10;
            //kasutaja peab seda numbrit ära arvama;
            //kui kasutaja suutis seda numbrit ära arvata, siis ta on mängu võitnud;
            //katsete arv on piiramatu;
            //programm genereerib juhuslikku numbrit üks kord;

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);

            

            while (cpuNumber != 0)
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
                    Console.WriteLine("Vale number. Proovi uuesti!"); 
                }

            }

            Console.WriteLine("Kena päeva jätku!");
            Console.ReadLine();
            
        }
    }
}
