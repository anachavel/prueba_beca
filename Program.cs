using System;
using System.Timers;
// Prueba
namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exitApp = false;

            do
            {
                Console.WriteLine("Elige un producto (Azúcar, Sal, Café):");
                var seleccionado = Console.ReadLine();

                switch (seleccionado)
                {
                    case "Azúcar":
                        float precio = 2.35F;
                        float descuento = 0.2F;
                        float total = precio - (precio * descuento);

                        Console.WriteLine($"El precio final del producto '{seleccionado}' es de: {total} euros.");
                        break;

                    case "Sal":
                        precio = 1.95F;
                        descuento = 0.15F;
                        total = precio - (precio * descuento);

                        Console.WriteLine($"El precio final del producto '{seleccionado}' es de: {total} euros.");
                        break;

                    case "Café":
                        precio = 3.95F;
                        descuento = 0.05F;
                        total = precio - (precio * descuento);

                        Console.WriteLine($"El precio final del producto '{seleccionado}' es de: {total} euros.");
                        break;

                    case "quit":
                        exitApp = true;
                        break;

                    default:
                        Console.WriteLine("Esa no es una opción válida.");
                        break;
                }
                Console.WriteLine();
            }
            while (!exitApp);
        }
    }
}