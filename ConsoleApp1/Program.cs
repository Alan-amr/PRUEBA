using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese Texto: ");
            String textoOr = Console.ReadLine();
            char[] var = textoOr.ToCharArray();
            Array.Reverse(var);
            String textoRevertido = new string(var);
            Console.WriteLine(textoRevertido);
        }
    }
}
