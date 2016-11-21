using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace proyecto
{
    class Lista_Notas_Credito
    {
        private FileStream fs;
        private BinaryWriter bw;
        private BinaryReader br;
        private int nregistro;
        private int tamañoReg=200;
        //private bool regEliminado = false;

        public Lista_Notas_Credito(string fichero)
        {
            if (Directory.Exists(fichero))
                throw new IOException(Path.GetFileName(fichero)+"no es un fichero");
            fs = new FileStream(fichero,FileMode.OpenOrCreate,FileAccess.ReadWrite);
            bw = new BinaryWriter(fs);
            br = new BinaryReader(fs);
            nregistro = (int)Math.Ceiling((double)fs.Length/(double)tamañoReg);
        }

        public void CerrarFichero()
        {
            bw.Close();
            br.Close();
            fs.Close();
        }

        public int NumeroRegistro()
        {
            return nregistro;
        }

        public bool EscribirReg(int i,Factura factura)
        {
            if (i >= 0 && i <= nregistro)
            {
                if (factura.Tamaño + 8 < tamañoReg)
                {
                    bw.BaseStream.Seek(i * tamañoReg, SeekOrigin.Begin);
                    bw.Write(factura.Remitente);
                    bw.Write(factura.Destinatario);
                    bw.Write(factura.Monto);
                    bw.Write(factura.Detalle);
                    bw.Write(factura.Fecha);
                }
                else Console.WriteLine("tamaño excedido del registro");
            }
            else Console.WriteLine("numero de registro fuera de limites");

            return false;
        }

        public void AñadirRegistro(Factura factura)
        {
            if (EscribirReg(nregistro, factura))
            {
                nregistro++;
            }
        }

        public Factura LeerRegistro(int i)
        {
            if (i >= 0 && i <= nregistro)
            {
                //Situar el puntero de L/E
                br.BaseStream.Seek(i * tamañoReg, SeekOrigin.Begin);
                // toma lo datos
                string remitente = br.ReadString();
                string destinatario = br.ReadString();
                double costo = br.ReadDouble();
                string detalles = br.ReadString();
                string fecha = br.ReadString();

                return new Factura(remitente, destinatario, costo, detalles, fecha);
            }
            else
            {
                return null;
            }
        }
    }
}
