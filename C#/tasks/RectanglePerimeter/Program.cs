﻿using System;

namespace Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal height, width;
            Console.Write("Ingrese el valor de la altura del rectángulo: ");
            height = decimal.Parse(Console.ReadLine());
            Console.Write("Ingrese el valor de la base del rectánuglo: ");
            width = decimal.Parse(Console.ReadLine());
            var perimteter = (height + width) * 2;
            Console.WriteLine($"El perímetro del rectángulo es: {perimteter}");
        }
    }

}