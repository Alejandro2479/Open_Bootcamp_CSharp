using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sesion_4___Ejercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ejercicio 1
            int multiplicador = 1;

            Console.Write("Ingrese un numero: ");
            int numeroUsuario1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");

            while(multiplicador <= 10)
            {
                Console.WriteLine($"{numeroUsuario1} x {multiplicador} = {numeroUsuario1 * multiplicador}");
                multiplicador++;
            }
            Console.Write("\n");

            // Ejercicio 2
            int numeroUsuario2;
            int contadorPositivo = 0;
            int contadorNegativo = 0;

            do
            {
                Console.Write("Introduce un numero (0 para salir): ");
                numeroUsuario2 = int.Parse(Console.ReadLine());
                Console.Write("\n");

                if (numeroUsuario2 > 0)
                {
                    contadorPositivo++;
                    Console.WriteLine("El numero es positivo");
                }
                else if (numeroUsuario2 < 0)
                {
                    contadorNegativo++;
                    Console.WriteLine("El numero es negativo");
                }
                else
                {
                    Console.WriteLine("Has introducido el numero 0, programa finalizado");
                }
            } while (numeroUsuario2 != 0);
            Console.WriteLine($"Has introducido {contadorPositivo} numeros positivos y {contadorNegativo} numeros negativos");
            Console.Write("\n");

            // Ejercicio 3            
            Console.Write("Introduzca el ancho del rectángulo/cuadrado: ");
            int ancho = int.Parse(Console.ReadLine());

            Console.Write("Introduzca el alto del rectángulo/cuadrado: ");
            int alto = int.Parse(Console.ReadLine());

            Console.Write("Introduzca 1 para relleno o 0 para no relleno: ");
            int relleno = int.Parse(Console.ReadLine());

            Console.Write("Introduzca el número de cuadrados/rectángulos que desea dibujar: ");
            int cantidad = int.Parse(Console.ReadLine());

            Console.Write("\n");

            for (int contador1 = 0; contador1 < cantidad; contador1++)
            {
                if (ancho == alto)
                {
                    // Cuadrado
                    for (int contador2 = 0; contador2 < alto; contador2++)
                    {
                        for (int contador3 = 0; contador3 < ancho; contador3++)
                        {
                            if (relleno == 1 || contador2 == 0 || contador2 == alto - 1 || contador3 == 0 || contador3 == ancho - 1)
                            {
                                Console.Write("*");
                            }
                            else
                            {
                                Console.Write(" ");
                            }
                        }
                        Console.WriteLine();
                    }
                }
                else
                {
                    // Rectángulo
                    for (int contador2 = 0; contador2 < alto; contador2++)
                    {
                        for (int contador3 = 0; contador3 < ancho; contador3++)
                        {
                            if (relleno == 1 || contador2 == 0 || contador2 == alto - 1 || contador3 == 0 || contador3 == ancho - 1)
                            {
                                Console.Write("*");
                            }
                            else
                            {
                                Console.Write(" ");
                            }
                        }
                        Console.WriteLine();
                    }
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
