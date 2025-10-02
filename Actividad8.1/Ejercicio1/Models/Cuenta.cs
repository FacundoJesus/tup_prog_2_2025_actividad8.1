using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class Cuenta: IComparable
    {
        public string Nombre { get; set; }
        public int DNI { get; set; }

        private double importeTotal = 0;
        public double Importe {
            get
            {
                return importeTotal;
            }
            set
            {
                importeTotal += value;
            }
        }

        public Cuenta (string nombre, int dni, double importe)
        {
            this.Nombre = nombre;
            this.DNI = dni;
            this.Importe = importe;
        }

        public override string ToString()
        {
            return $"{this.Nombre} ({this.DNI}) Importe:{this.Importe:c2}";
        }

        public int CompareTo(object obj)
        {
            Cuenta nuevaCuenta = obj as Cuenta;
            if(nuevaCuenta != null) {
                return this.DNI.CompareTo(nuevaCuenta.DNI);
            }
            return -1;
        }

    }
}

