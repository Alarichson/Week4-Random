using System;

namespace LoopsAndRandomNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada PIN-koodi;
            //programm võrdleb sisestatud PIN-koodi arvuga 1234;
            //kui sisestatud PIN-kood on 1234, siis konsool kuvab "Tere tulemast!";
            //kui sisestatud PIN-kood on midagi muud, siis konsool kuvab "Vale PIN. Proovi uuesti";
            //kasutajal kokku kolm katset;

            int i = 0; //i - interation

            while (i < 3) //While-loop >> i = 1; 1 < 3 --> true; 2 < 3 --> true; 3 < 3 --> false
            {
                Console.WriteLine("Sisesta PIN-kood:");
                int userPin = Convert.ToInt32(Console.ReadLine());

                if(userPin == 1234)
                {
                    Console.WriteLine("Tere tulemast!");
                    break;
                }
                else
                {
                    i++; //(i = i + 1) == i++
                    Console.WriteLine($"Vale PIN. {3 - i} katset on jäänud.");
                }

                
                
            }

            Console.WriteLine("Kena päeva!");

        }
    }
}
