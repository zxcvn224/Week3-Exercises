using System;

namespace AndExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //tingimused sisseastumiseks
            //miinimum matemaatikas 85 punkti;
            //miinimum keemias 90 punkti;
            //miinimum bioloogias 95 punkti;
            //programm küsib kasutajal sisestada tema
            //eksami punktid ja otsustab, kas kasutaja
            //saab arstiks õppida
            Console.WriteLine("Sisesta matemaatika eksami tulemas:");
            int matemaatika = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("sisesta keemia eksami tulemus");
            int keemia = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("sisesta biloogia eksami tulemus");
            int bioloogia = Convert.ToInt32(Console.ReadLine());

            if(matemaatika >= 85 && keemia >= 90 && bioloogia >= 95)
            {
                Console.WriteLine("saad arstiks õppida");
            }
            else
            {
                Console.WriteLine("ei saa arstiks õppida");
            }
        }
    }
}
