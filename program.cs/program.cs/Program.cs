using System;

namespace ClasseBatiment
{
    class Program
    {
        static void Main(string[] args)
        {
            Batiment Batiment1 = new Batiment("96 Jacques Cartier");
            Console.WriteLine(Batiment1);
            Maison Maison1 = new Maison("14 Adams", 4);
            Console.WriteLine(Maison1);
        }
    }
}
