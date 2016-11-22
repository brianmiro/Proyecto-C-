using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.IO;
using System.Configuration;

namespace WebApp
{
    public class Global : System.Web.HttpApplication
    {

        void Application_Start(object sender, EventArgs e)
        {
            // Código que se ejecuta al iniciarse la aplicación
            //verificar si el archivo existe sino q lo cree vacio
            //nota de debitos
            var dir = Server.MapPath("/Data");
            var file = Path.Combine(dir, ConfigurationManager.AppSettings["FileDebito"]);
            //nota de credito
            var dirC = Server.MapPath("/Data");
            var fileC = Path.Combine(dir, ConfigurationManager.AppSettings["FileCredito"]);
            //movimiento recurrente
            var dirR = Server.MapPath("/Data");
            var fileR = Path.Combine(dir, ConfigurationManager.AppSettings["FileRecurrente"]);
            //Faturas
            var dirF = Server.MapPath("/Data");
            var fileF = Path.Combine(dir, ConfigurationManager.AppSettings["FileFactura"]);
            
            if(!File.Exists(file)) {

                using (File.Create(file));
                using(File.Create(fileC));
                using(File.Create(fileR));
                using(File.Create(fileF));

            }
        }

        void Application_End(object sender, EventArgs e)
        {
            //  Código que se ejecuta cuando se cierra la aplicación

        }

        void Application_Error(object sender, EventArgs e)
        {
            // Código que se ejecuta al producirse un error no controlado

        }

        void Session_Start(object sender, EventArgs e)
        {
            // Código que se ejecuta cuando se inicia una nueva sesión

        }

        void Session_End(object sender, EventArgs e)
        {
            // Código que se ejecuta cuando finaliza una sesión.
            // Nota: el evento Session_End se desencadena sólo cuando el modo sessionstate
            // se establece como InProc en el archivo Web.config. Si el modo de sesión se establece como StateServer 
            // o SQLServer, el evento no se genera.

        }

    }
}
