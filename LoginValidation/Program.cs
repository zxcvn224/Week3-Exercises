using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada kasutajatunnus ja parool
            //programm kontrollib sisestatud andmed
            //kui sisestatud kasutaja tunnus on "admin" ja
            //sisestatud parool on "admin1234"
            //siis programm kuvab "tere tulemast"
            //muul juhul programm kuvab "vale kasutaja tunnus või parool. proovige uuesti"

            //option 1
            Console.WriteLine("sisesta kasutaja tunnus:");
            string username = Console.ReadLine();
            Console.WriteLine("Sisesta salasõna");
            string password = Console.ReadLine();

            /*if(username == "admin" && password == "admin1234")
            {
                Console.WriteLine("Tere tulemast!");
            }
            else
            {
                Console.WriteLine("Vale kasutaja tunnus või parool. Proovi uuesti");
            }*/
            
            if(username != "admin" || password != "admin1234")
            {
                Console.WriteLine("Vale kasutaja tunnus või parool. Proovi uuesti");
            }
            else
            {
                Console.WriteLine("Tere tulemast!");
            }

               








        }
    }
}
