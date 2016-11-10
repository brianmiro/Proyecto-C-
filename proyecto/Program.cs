using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace proyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            string fichero = "D:/prueba/listaDebitos.txt";
            Lista_Facturas_Debito debito = new Lista_Facturas_Debito(fichero);

            Nota_Debito factura = new Nota_Debito(" guillermo "," pablo ", 3000 ,"fragil producto","12/12/2016");

            debito.AñadirRegistro(factura);

            Nota_Debito facturaMuestra = debito.LeerRegistro(1);

            Console.WriteLine("REMITENTE :  " + facturaMuestra.Remitente);
            Console.WriteLine("DESTINATARIO :  " + facturaMuestra.Destinatario);
            Console.WriteLine("MONTO :  " + facturaMuestra.Monto);
            Console.WriteLine("DETALLE :  " + facturaMuestra.Detalle);
            Console.WriteLine("FECHA :  " + facturaMuestra.Fecha);

            Console.ReadKey();
        }
    }
}
