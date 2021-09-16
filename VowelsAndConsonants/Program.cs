using System;

namespace VowelsAndConsonants
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada tähte
            //programm kontrllib, kas sisestatud täht on
            //täishäälik või kaashäälik
            //kui sisestatud täht on kaashäälik
            //programm kuvab "kaashäälik"
            //kastuame switch'i

            //"mingi sõna" - string
            // 'a' - charecter ehk char

            Console.WriteLine("Siseta täht");
            char character = Convert.ToChar(Console.ReadLine().ToLower());

            switch (character)
            {
                case 'a':
                    Console.WriteLine("Täishäälik");
                    break;
                case 'e':
                    Console.WriteLine("Täishäälik");
                    break;
                case 'i':
                    Console.WriteLine("Täishäälik");
                    break;
                case 'o':
                    Console.WriteLine("Täishäälik");
                    break;
                case 'u':
                    Console.WriteLine("Täishäälik");
                    break;
                default:
                    Console.WriteLine("Kaashäälik");
                    break;
            }
            Console.WriteLine("kena päeva")
       
        }
    } 
}