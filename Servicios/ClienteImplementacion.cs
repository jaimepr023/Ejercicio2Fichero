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
            Console.WriteLine("Dame la direccion del deudor: ");
            cliente.DireccionDelDeudor = Console.ReadLine();
            Console.WriteLine("Dame el cofigo postal del deudor:");
            cliente.CodigoPostal = Int32.Parse(Console.ReadLine());            
            Console.WriteLine("Dame la poblacion del deudor:");
            cliente.Poblacion= Console.ReadLine();            
            Console.WriteLine("Dame ls provincia y pais del deudor(separado por un espacio): ");
            cliente.Provincia_Pais= Console.ReadLine();            
            Console.WriteLine("Dame el IBAN del deudor: ");
            cliente.NumIBAN = Console.ReadLine(); 
            Console.WriteLine("Dame el SWIFT del deudor: ");
            cliente.Swift = Console.ReadLine();      
            Console.WriteLine("Dame el tipo de pago (R/U): ");
            cliente.TipoPago = Convert.ToChar(Console.ReadLine());
            cliente.Identificador = sumid(clienteList);
            clienteList.Add(cliente);

        }

        private int sumid(List<Cliente> clienteList)
        {
            int idCalculo;
            int tamañoLista = clienteList.Count;

            if(tamañoLista > 0)
            {
                idCalculo = clienteList[tamañoLista - 1].Identificador + 1;
            }
            else
            {
                idCalculo = 1;
            }
            return idCalculo;
        }
    }
}
