using System;

namespace InstagramAgeValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja sünniaastat
            //programm arbutab kasutaja vanust
            //programm kontrollib, kas kasutaja on vanem kui 13 või 13 aastat vana;
            //kui kasutaja on 13 aastat vana või vanem,
            //siis ta võib instagram'i kasutada
            //kui kasutaja on noorem, kui 13, siis ta on liiga noor.

            Console.WriteLine("sisestage oma sünniaasta");

            int Birth = Convert.ToInt32(Console.ReadLine());

            int age = 2021 - Birth;

            if(Birth == 2008)
            {
                Console.WriteLine("oled piisavalt vana, tere tulemast");
            }
            else if (Birth >2008) {
                Console.WriteLine("oled liiga noor!");
            }
            else
            {
                Console.WriteLine("Oled piisavalt vana, tere tulemast");
            }
        }
    }
}
