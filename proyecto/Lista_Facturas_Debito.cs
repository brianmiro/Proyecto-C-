using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace proyecto
{
    class Lista_Facturas_Debito
    {
        private FileStream fs;
        private BinaryWriter bw;
        private BinaryReader br;
        private int nregistro;
        private int tamañoReg=200;
        //private bool regEliminado = false;

        public Lista_Facturas_Debito(string fichero)
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

        public bool EscribirReg(int i,Nota_Debito debito)
        {
            if (i >= 0 && i <= nregistro)
            {
                if (debito.Tamaño + 8 < tamañoReg)
                {
                    bw.BaseStream.Seek(i * tamañoReg, SeekOrigin.Begin);
                    bw.Write(debito.Remitente);
                    bw.Write(debito.Destinatario);
                    bw.Write(debito.Monto);
                    bw.Write(debito.Detalle);
                    bw.Write(debito.Fecha);
                }
                else Console.WriteLine("tamaño excedido del registro");
            }
            else Console.WriteLine("numero de registro fuera de limites");

            return false;
        }

        public void AñadirRegistro(Nota_Debito debito)
        {
            if (EscribirReg(nregistro, debito))
            {
                nregistro++;
            }
        }

        public Nota_Debito LeerRegistro(int i)
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

                return new Nota_Debito(remitente, destinatario, costo, detalles, fecha);
            }
            else
            {
                return null;
            }
        }


    }
}
