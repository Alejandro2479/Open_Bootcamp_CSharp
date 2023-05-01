using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sesion_2___Ejercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ejercicio 1
            Console.WriteLine("Ingrese su nombre:");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su apellido:");
            string apellido = Console.ReadLine();
            Console.WriteLine("Ingrese su edad:");
            string edad = Console.ReadLine();
            Console.WriteLine("Sabe programar?:");
            string programar = Console.ReadLine();
            Console.WriteLine($"Su nombre es {nombre} {apellido}, tiene {edad} años y {programar} sabe programar");

            // Ejercicio 2
            int puertas = 4;
            int ruedas = 4;
            string marca = "Toyota";
            bool itvVigente = true;
            Console.WriteLine($"El coche tiene {puertas} puertas, {ruedas} ruedas, es de marca {marca} y su ITV está vigente: {itvVigente}");

            // Console 3
            int anios = 20;
            bool esMayor = anios >= 18;
            Console.WriteLine("Es mayor de edad? " + esMayor);

            char letra = 'a';
            bool esA = letra == 'a';
            Console.WriteLine("La letra es 'a'? " + esA);

            int x = 10;
            int y = 20;
            bool ambasVerdaderas = (x > 5) && (y < 30);
            Console.WriteLine("Se cumplen dos condiciones a la vez? " + ambasVerdaderas);

            bool unaVerdadera = (x > 5) || (y < 10);
            Console.WriteLine("Se cumple una de dos condiciones a la vez? " + unaVerdadera);

            Console.Read();
        }
    }
}
