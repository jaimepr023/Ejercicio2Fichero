using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2Fichero.Dtos
{
    internal class Cliente
    {
        string nombreCliente = "aaaaa";
        string direccionDelDeudor = "aaaaa";
        int codigoPostal = 0;
        string poblacion = "aaaaa";
        string provincia_Pais = "aaaaa";
        string numIBAN = "aaaaa";
        string swift = "aaaaa";
        char tipoPago = 'A';
        int identificador = 0;

        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string DireccionDelDeudor { get => direccionDelDeudor; set => direccionDelDeudor = value; }
        public int CodigoPostal { get => codigoPostal; set => codigoPostal = value; }
        public string Poblacion { get => poblacion; set => poblacion = value; }
        public string Provincia_Pais { get => provincia_Pais; set => provincia_Pais = value; }
        public string NumIBAN { get => numIBAN; set => numIBAN = value; }
        public string Swift { get => swift; set => swift = value; }
        public char TipoPago { get => tipoPago; set => tipoPago = value; }
        public int Identificador { get => identificador; set => identificador = value; }

        public Cliente(string nombreCliente,string direccionDelDeudor, int codigoPostal, string poblacion, string provincia_Pais, string numIBAN, string swift, char tipoPago, int identificador)
        {
            this.nombreCliente = nombreCliente;
            this.direccionDelDeudor = direccionDelDeudor;
            this.codigoPostal = codigoPostal;
            this.poblacion = poblacion;
            this.provincia_Pais = provincia_Pais;
            this.numIBAN = numIBAN;
            this.swift = swift;
            this.tipoPago = tipoPago;
            this.identificador = identificador;
        }

        public Cliente()
        {
        }

        override
        public  string ToString()
        {
            return
                "Nombre del deudor: " + nombreCliente + "\n" +
                "Direccion del deudor: " + direccionDelDeudor + "\n" +
                "Codigo postal - Poblacion - Provincia/Pais: " + this.codigoPostal + " - " + this.poblacion + " - " + this.provincia_Pais + "\n" +
                "Numero de cuenta-IBAN \t\t\t" + "Swift-BIC \n" +
                numIBAN + "\t\t\t" + swift + "\n" +
                "\t\t\t\t Tipo de pago: " + tipoPago;
        }
    }
}
