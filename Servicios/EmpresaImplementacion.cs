using Ejercicio2Fichero.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2Fichero.Servicios
{
    internal class EmpresaImplementacion : EmpresaInterfaz
    {
   
        public void empresa(List<Empresa> lista)
        {
            Empresa empresa = new Empresa();
            lista.Add(empresa);

            
        }
    }
}
