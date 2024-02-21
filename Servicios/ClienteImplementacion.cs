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
            Cliente cliente = new Cliente();
            Console.WriteLine("Dame el nombre del deudor:");
            cliente.NombreCliente = Console.ReadLine();            
            Console.WriteLine("Dame el nombre del deudor:");
            cliente.DireccionDelDeudor = Console.ReadLine();
            Console.WriteLine("Dame el nombre del deudor:");
            cliente.CodigoPostal = Int32.Parse(Console.ReadLine());            
            Console.WriteLine("Dame el nombre del deudor:");
            cliente.Poblacion= Console.ReadLine();            
            Console.WriteLine("Dame el nombre del deudor:");
            cliente.Provincia_Pais= Console.ReadLine();            
            Console.WriteLine("Dame el nombre del deudor:");
            cliente.NumIBAN = Console.ReadLine(); 
            Console.WriteLine("Dame el nombre del deudor:");
            cliente.Swift = Console.ReadLine();      
            Console.WriteLine("Dame el nombre del deudor:");
            cliente.TipoPago = Convert.ToChar(Console.ReadLine()); 
            
            
            clienteList.Add(cliente);

        }

        private int sumid()
        {

        }
    }
}
