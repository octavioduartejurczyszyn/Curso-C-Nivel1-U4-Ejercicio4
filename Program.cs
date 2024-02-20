using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa para ingresar tres números y emitir un cartel
            // aclaratorio si la suma de los dos primeros es mayor al producto del segundo con el tercero.
            int n1, n2, n3;
            Console.WriteLine("Escriba un nro:");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Escriba otro:");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Escriba el último:");
            n3 = int.Parse(Console.ReadLine());
                if((n1 + n2) > (n2 * n3))
                Console.WriteLine("Sí, es mayor");

        }
    }
}
