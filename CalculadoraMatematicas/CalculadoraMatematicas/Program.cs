using System;

namespace main
{
    class Peogram
    {
        static void sumar()
        {
            Console.WriteLine("escriba su numero para sumar");
            int n1 = Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("escriba otro numero para sumar");
            int n2 = Convert.ToInt32(Console.ReadLine());
            int resul = n1 + n2;
            Console.WriteLine("tu resultdo es " + resul);
        }
        static void Main(string[] args) 
        {
            sumar();
            Console.WriteLine("0");

        }

    }
}