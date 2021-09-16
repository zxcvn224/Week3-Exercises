using System;

namespace WeatherReport
{
    class Program
    {
        static void Main(string[] args)
        {

            //Programm küsib mitu kraadi õues on;
            ///Kui õues on rohkem kui 35 kraadi, programm kuvab" Boiling hot";
            //Kui õues on 30 kuni 35 kraadi, programm kuvab "Hot";
            //Kui õues on 20 kuni 30 kraadi, programm kuvab "Nice";
            //Kui õues on 10 kuni 200 kraadi, programm kuvab "Chilly";
            //Kui õues on 0 kuni 10 kraadi, programm kuvab "cold";
            //Kui õues on alla 0 kraadi, programm kuvab "Freezin cold".

            Console.WriteLine("Mitu Kraadi õues on?");
            int Temp = Convert.ToInt32(Console.ReadLine());

            if (Temp >= 35)
            {
                Console.WriteLine("Boiling hot.");
            }
            else if (Temp >= 30 && Temp < 35)
            {
                Console.WriteLine("Hot.");
            }
            else if (Temp >= 20 && Temp < 30)
            {
                Console.WriteLine("Nice.");
            }
            else if (Temp >= 10 && Temp < 20)
            {
                Console.WriteLine("Chilly.");
            }
            else if (Temp >= 0 && Temp < 10)
            {
                Console.WriteLine("Cold.");
            }
            else
            {
                Console.WriteLine("Freezing cold.");
            }
















        }
    }
}
