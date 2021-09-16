using System;

namespace Week3Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsub kasutajal sisestada PIN koodi
            //programm võrdleb sisestatud PIN-koodi arvuga 1234
            //Kui sisestatud PIN-kood on 1234
            //programm kuvab konsoolis "Tere tulemast!"
            //Kui sisestatud PIN on vale, programm kuvab konsoolis
            //"Vale PIN. Proovi uuesti."
            Console.WriteLine("Tere Tulemast");
            Console.WriteLine("Palun sisestage PIN kood");
            int pin = Convert.ToInt32(Console.ReadLine());
            /*if(pin == 1234)
            {
                Console.WriteLine("Sisestatud PIN kood on õige!");
            }
            else
            {
                Console.WriteLine("VALE PIN KOOD!!");
            }*/

            if (pin != 1234) { 
               Console.writeline("Vale PIN. prooviga uuesti")
            }
            else
            {
                Console.WriteLine("õige");
            }



        }
    }
}
