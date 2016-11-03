using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    class Nota_Debito
    {
        //Atributos
        private Persona remitente; //vendedor,empresa
        private Persona destinatario; //cliente,usuario,empresa
        private double monto;
        private string detalle; //detalle de la informacion para el destinatario.
        private DateTime fecha; // fecha de expedicion.

      

        //Metodos
        public Nota_Debito(Persona r, Persona d, double m, string detall, DateTime f)
        {
            this.Remitente = r;
            this.Destinatario = d;
            this.Monto = m;
            this.Detalle = detall;
            this.Fecha = f;

        }
        public Persona Remitente
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

        public Persona Destinatario
        {
            get
            {
                return destinatario;
            }

            set
            {
                destinatario = value;
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
