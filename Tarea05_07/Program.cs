using System;

namespace Tarea05_07
{
    class Program
    {
        static void convierte (double euros, String moneda)
        {
            
            if (moneda == "libra")
            {
                Console.WriteLine("{0} euros son {1} libras.", euros, euros * 0.86);
            }
            if (moneda == "dolar")
            {
                Console.WriteLine("{0} euros son {1} dólares.", euros, euros * 1.28611);
            }
            if (moneda == "yen")
            {
                Console.WriteLine("{0} euros son {1} yenes.", euros, euros * 129.852);
            }
        }
        static void Main(string[] args)
        {
            double euros = 0;
            int opcion = -1;

            while (opcion != 0)
            {
                Console.WriteLine("_____________________________________");
                Console.WriteLine("Seleccione una opción: ");
                Console.WriteLine("1 - Convertir Euros a Libras.");
                Console.WriteLine("2 - Convertir Euros a dólares. ");
                Console.WriteLine("3 - Convertor Euros a Yenes.");
                Console.WriteLine("0 - Salir del programa.");
                Console.WriteLine("_____________________________________");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("Introduce la cantidad de euros que quieres convertir a libras: ");
                        euros = Convert.ToDouble(Console.ReadLine());
                        convierte(euros, "libra");
                        break;
                    case 2:
                        Console.Write("Introduce la cantidad de euros que quieres convertir a dólares: ");
                        euros = Convert.ToDouble(Console.ReadLine());
                        convierte(euros, "dolar");
                        break;
                    case 3:
                        Console.Write("Introduce la cantidad de euros que quieres convertir a yenes: ");
                        euros = Convert.ToDouble(Console.ReadLine());
                        convierte(euros, "yen");
                        break;
                    case 0:
                        Console.WriteLine("Fin del programa.");
                        break;
                    default:
                        Console.WriteLine("Opción incorrecta!!!.");
                        break;
                }
            }

            Console.WriteLine("Gracias por utilizar CONVERSOR 0.1a ...");
        }
    }
}
