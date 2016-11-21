using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace proyecto
{
    class Lista_Movimiento_Recurrente
    {
        private FileStream fs;
        private BinaryWriter bw;
        private BinaryReader br;
        private int nregistro;
        private int tamañoReg=200;
        //private bool regEliminado = false;

        public Lista_Movimiento_Recurrente(string fichero)
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

        public bool EscribirReg(int i,Movimiento_Recurrentes recurrente)
        {
            if (i >= 0 && i <= nregistro)
            {
                if (recurrente.Tamaño+ 8 < tamañoReg)
                {
                    bw.BaseStream.Seek(i * tamañoReg, SeekOrigin.Begin);
                    bw.Write(recurrente.Monto);
                    bw.Write(recurrente.Fecha_inicio);
                    bw.Write(recurrente.Frecuencia_facturacion);
                    bw.Write(recurrente.Plazo);
                }
                else Console.WriteLine("tamaño excedido del registro");
            }
            else Console.WriteLine("numero de registro fuera de limites");

            return false;
        }

        public void AñadirRegistro(Movimiento_Recurrentes recurrente)
        {
            if (EscribirReg(nregistro, recurrente))
            {
                nregistro++;
            }
        }

        public Movimiento_Recurrentes LeerRegistro(int i)
        {
            if (i >= 0 && i <= nregistro)
            {
                //Situar el puntero de L/E
                br.BaseStream.Seek(i * tamañoReg, SeekOrigin.Begin);
                // toma lo datos
                double monto = br.ReadDouble();
                string fecha_inicio = br.ReadString();
                int frecuencia = br.ReadInt32();
                int plazo = br.ReadInt32();

                return new Movimiento_Recurrentes(monto , fecha_inicio , frecuencia , plazo);
            }
            else
            {
                return null;
            }
        }

    }
}
