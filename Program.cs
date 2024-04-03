using System;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            float precio = 5.35F;
            float descuento = 0.2F;
            float total = precio - (precio * descuento);

            Console.WriteLine($"El precio final del producto es: {total}");
        }
    }
}