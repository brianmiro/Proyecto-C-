using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    class Movimiento_Recurrente
    {
        //Atributos
        private double monto;
        private DateTime fecha_inicio;
        private int frecuencia_facturacion; //cantidad de dias en que se realiza la facturacion

      
        //Metodos
        public Movimiento_Recurrente(double m,DateTime f,int frec)
        {
            this.Monto = m;
            this.Frecuencia_facturacion = frec;
            this.Fecha_inicio = f;
        }
        public double Monto
        {
            get
            {
                return monto;
            }

            set
            {
                monto = value;
            }
        }

        public DateTime Fecha_inicio
        {
            get
            {
                return fecha_inicio;
            }

            set
            {
                fecha_inicio = value;
            }
        }

        public int Frecuencia_facturacion
        {
            get
            {
                return frecuencia_facturacion;
            }

            set
            {
                frecuencia_facturacion = value;
            }
        }
    }
}
