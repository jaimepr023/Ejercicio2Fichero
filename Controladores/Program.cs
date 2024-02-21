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

          
            Empresa empresa = new Empresa();



            using (StreamWriter sw = new StreamWriter(archivo))
            {
                sw.WriteLine("\t\t\t\t Orden de domiciliacion de adeudo directo Sepa");
            }
            using (StreamWriter sw = new StreamWriter(archivo, true))
            {

               sw.Write(
                 "------------------------------------------------------------------------------------------------- \n" +
                 $"Identificador del Acreedor:   {empresa.IdentificadorDelAcreedor}  \n" +
                 $"Nombre del Acreedor:  {empresa.NombreDelAcreedor}  \n" +
                 $"Direccion: {empresa.Direccion} \n" +
                 $"Codigo postal - Poblacion - Provincia/Pais: {empresa.CodigoPostal}  -   {empresa.Poblacion}  -  {empresa.Provincia_Pais} \n" +
                 "------------------------------------------------------------------------------------------------- \n");

            }

        }
    }
}