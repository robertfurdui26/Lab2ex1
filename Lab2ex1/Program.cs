using System;

namespace Lab2ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ex 1: Scrieti un program care va afisa suma cifrelor unui numar n, n fiind
             citit de la tastatura.*/

            Console.WriteLine("ACEST PROGRAM VA CALCULA SUMA CIFRELOR UNUI NUMAR");

            Console.WriteLine("Introduceti n ");
            int n = int.Parse(Console.ReadLine());

            int suma = 0;
            while (n != 0) 
            {
                int cifra = n % 10; //extragem ultima cifra
                suma += cifra; //adaugam vifra la suma totala
                n /= 10; //eliminam ultima cifra prin impartirea la 10
            }
            Console.WriteLine("Suma cifrelor este " +suma);
        }
    }
}