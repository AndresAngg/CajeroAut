using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace CajeroBeta
{
   public class cliente
    {
        //VERSIÓN 3.8
        private string Nºcuenta;
        private string clave;
        private string NIdentificacion;
        private string nombre;
        private double saldo;

        public string Nºcuenta1
        {
            get
            {
                return Nºcuenta;
            }

            set
            {
                Nºcuenta = value;
            }
        }

        public string Clave
        {
            get
            {
                return clave;
            }

            set
            {
                clave = value;
            }
        }

        public string NIdentificacion1
        {
            get
            {
                return NIdentificacion;
            }

            set
            {
                NIdentificacion = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public double Saldo
        {
            get
            {
                return saldo;
            }

            set
            {
                saldo = value;
            }
        }








        //private string Nºcuenta;
        //private string clave;
        //private string Nidentificacion;
        //private string nombre;
        //private double saldo;




    }
}
