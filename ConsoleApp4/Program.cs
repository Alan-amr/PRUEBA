﻿using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Imgrese parametro: ");
            String op = Console.ReadLine();
            switch (op)
            {
                case "Amarillo":
                    for (int i = 1; i <= 10; i++)
                    {
                        int res = 2 * i;
                        Console.WriteLine("2x" + i + " = " + res);
                    }
                    break;
                case "Morado":
                    for (int i = 1; i <= 10; i++)
                    {
                        int res = 7 * i;
                        Console.WriteLine("7x" + i + " = " + res);
                    }
                    break;
                case "Rosa":
                    for (int i = 1; i <= 10; i++)
                    {
                        int res = 9 * i;
                        Console.WriteLine("9x" + i + " = " + res);
                    }
                    break;
                case "Azul":
                    for (int i = 1; i <= 10; i++)
                    {
                        int res = 6 * i;
                        Console.WriteLine("6x" + i + " = " + res);
                    }
                    break;
                case "Blanco":
                    for (int i = 1; i <= 10; i++)
                    {
                        int res = 12 * i;
                        Console.WriteLine("12x" + i + " = " + res);
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
