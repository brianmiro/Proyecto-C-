using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace proyecto
{
    class Nota_Credito
    {
        //Atributos
        private string remitente; //vendedor,empresa
        private string destinatario; //cliente,usuario,empresa
        private double monto;
        private string detalle; //detalle de la informacion para el destinatario.
        private DateTime fecha; // fecha de expedicion.

   


        //Metodos
        public Nota_Credito(string r,string d,double m,string detall,DateTime f)
        {
            this.Remitente = r;
            this.Destinatario = d;
            this.Monto = m;
            this.Detalle = detall;
            this.Fecha = f;
        }
        public string Remitente
        {
            get
            {
                return remitente;
            }

            set
            {
                remitente = value;
            }
        }

        public string Destinatario
        {
            get
            {
                return Destinatario;
            }

            set
            {
                Destinatario = value;
            }
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

        public string Detalle
        {
            get
            {
                return detalle;
            }

            set
            {
                detalle = value;
            }
        }

        public DateTime Fecha
        {
            get
            {
                return fecha;
            }

            set
            {
                fecha = value;
            }
        }
    }
}
