using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2Fichero.Dtos
{
    internal class Empresa
    {
        

        string identificadorDelAcreedor = "A82553447";

        string nombreDelAcreedor = "Jaime Prieto Rubio";

        string direccion = "C. la Pañoleta, 4 ";

        int codigoPostal = 41910 ;

        string poblacion = "Camas";

        string provincia_Pais = "Sevilla/España";

       
        public string IdentificadorDelAcreedor { get => identificadorDelAcreedor;  }
        public string NombreDelAcreedor { get => nombreDelAcreedor;  }
        public string Direccion { get => direccion;  }
        public int CodigoPostal { get => codigoPostal;  }
        public string Poblacion { get => poblacion;  }
        public string Provincia_Pais { get => provincia_Pais;}

        public Empresa(string identificadorDelAcreedor, string nombreDelAcreedor, string direccion, int codigoPostal, string poblacion, string provincia_Pais)
        {
            this.identificadorDelAcreedor = identificadorDelAcreedor;
            this.nombreDelAcreedor = nombreDelAcreedor;
            this.direccion = direccion;
            this.codigoPostal = codigoPostal;
            this.poblacion = poblacion;
            this.provincia_Pais = provincia_Pais;
        }

        public Empresa()
        {
        }
    }
}
