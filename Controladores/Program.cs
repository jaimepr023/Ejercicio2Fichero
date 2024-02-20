using Ejercicio2Fichero.Dtos;
using Ejercicio2Fichero.Servicios;

namespace Ejercicio2Fichero.Controladores
{
    class program
    {
        public static void Main(string[] args)
        {
            string archivo = "C:\\Users\\profesor\\Desktop\\Adeudos\\NombreApellido1.txt";
            EmpresaInterfaz empresaInterfaz = new EmpresaImplementacion();

            using(StreamWriter sw =  new StreamWriter(archivo))
            {
                sw.WriteLine("\t\t\t Orden de domiciliacion de adeudo directo Sepa");
            }

            List<Empresa> empresaLista = new List<Empresa>();
            string formatoEmpresa;
            string formatoCliente;

            empresaInterfaz.empresa(empresaLista);















            using (StreamWriter sw = new StreamWriter(archivo, true))
            {

                foreach (Empresa empresa1 in empresaLista)
                {
                    formatoEmpresa = empresa1.ToString();

                    sw.Write(formatoEmpresa);

                }
            }
           
        }
    }
}