using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Sesion_3
{
    public struct Cliente
    {
        public string NombreCompleto;
        public string Telefono;
        public string Direccion;
        public string Email;
        public bool EsNuevoCliente;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente1 = new Cliente();
            cliente1.NombreCompleto = "Alejandro Otalvaro";
            cliente1.Telefono = "7777";
            cliente1.Direccion = "Calle 123";
            cliente1.Email = "alejandro@gmail.com";
            cliente1.EsNuevoCliente = true;

            Console.WriteLine($"Nombre completo: {cliente1.NombreCompleto}, Teléfono: {cliente1.Telefono}, Dirección: {cliente1.Direccion}, Email: {cliente1.Email}, ¿Es nuevo cliente?: {cliente1.EsNuevoCliente}");

            Console.Read();
        }
    }
}
