using Ejercicio2Fichero.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2Fichero.Servicios
{
    internal class ClienteImplementacion : ClienteInterfaz
    {
        public void listaCliente(List<Cliente> clienteList)
        {
            Console.WriteLine("Dame el nombre del deudor:");
            string nombre = Console.ReadLine();

        }
    }
}
