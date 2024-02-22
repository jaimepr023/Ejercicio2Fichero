using Ejercicio2Fichero.Dtos;
using Ejercicio2Fichero.Servicios;

namespace Ejercicio2Fichero.Controladores
{
    class program
    {
        public static void Main(string[] args)
        {
            string archivo = "C:\\Users\\vspc\\OneDrive\\Escritorio\\Adeudos\\NombreApellido1.txt";
            DateTime fecha = DateTime.Today;
            EmpresaInterfaz empresaInterfaz = new EmpresaImplementacion();
            ClienteInterfaz cliente = new ClienteImplementacion();
            List<Cliente> listaCliente = new List<Cliente>();
            Empresa empresa = new Empresa();
            string afirmacion;
            do
            {
                cliente.listaCliente(listaCliente);
                using (StreamWriter sw = new StreamWriter(archivo))
                {
                    sw.WriteLine("\t\t\t\t Orden de domiciliacion de adeudo directo Sepa");
                }
                foreach (Cliente cliente1 in listaCliente)
                {
                    using (StreamWriter sw = new StreamWriter(archivo, true))
                    {

                        sw.Write(
                          "------------------------------------------------------------------------------------------------- \n" +
                          $"Identificador del Acreedor:   {empresa.IdentificadorDelAcreedor}  \n" +
                          $"Nombre del Acreedor:  {empresa.NombreDelAcreedor}  \n" +
                          $"Direccion: {empresa.Direccion} \n" +
                          $"Codigo postal - Poblacion - Provincia/Pais: {empresa.CodigoPostal}  -   {empresa.Poblacion}  -  {empresa.Provincia_Pais} \n" +
                          "------------------------------------------------------------------------------------------------- \n");
                        sw.Write(
                            $"Id del deudor: {cliente1.Identificador} \n" +
                            $"Nombre del deudro {cliente1.NombreCliente} \n" +
                            $"Direccion del deudor: {cliente1.DireccionDelDeudor} \n" +
                            $"Codigo postal - Poblacion - Provincia/Pais: {cliente1.CodigoPostal}  -   {cliente1.Poblacion}  -  {cliente1.Provincia_Pais} \n" +
                            $"Numero de cuenta - IBAN: \t\t Swift - BIC:\n" +
                            $"{cliente1.NumIBAN} \t\t\t\t {cliente1.Swift} \n" +
                            $"\t\t\t\t\t Tipo de pago: {cliente1.TipoPago} \n" +
                            $"{fecha} \n" +
                             "------------------------------------------------------------------------------------------------- \n");
                    }
                }
                Console.WriteLine("¿Quieres volver a meter otro deudor?(s/n):");
                afirmacion = Console.ReadLine();
            } while (afirmacion.Equals("s"));
          
            

        }
    }
}