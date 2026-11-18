//Exercitiu 1
//Rezolvati ecuatia de gradul 1 cu o necunoscuta: ax+b = 0, unde a si b sunt date de intrare
using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduceti a: ");

        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Introduceti b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        if (a != 0)
        {
            double x = -b / a;
            Console.WriteLine("x = " + x);
        }
        else
        {
            Console.WriteLine("a trebuie sa fie diferit de 0");
        }
    }
}


