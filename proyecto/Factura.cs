using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace proyecto
{
    class Factura
    {
       //Atributos
       private string remitente;
       private string destinatario;
       private double monto;
       private DateTime fecha;  //en la que se genera un mov. de pago o cobro

       

        public Factura()
        {
        }
        public Factura(string r,string d,double m,DateTime f)
        {
            this.Destinatario = d;
            this.Remitente = r;
            this.Monto = m;
            this.Fecha = f;
        }

        //Metodos
        public string Remitente
        {
            get { return remitente; }
            set { remitente = value;}
        }

        public string Destinatario
        {
            get{return destinatario;}
            set{ destinatario = value; }
        }

        public double Monto
        {
            get { return monto;}
            set { monto = value; }
        }

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value;}
        }
    }
 }

