using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using proyecto;
using System.Configuration;
using System.IO;

namespace WebApp
{
    public partial class _Default : System.Web.UI.Page
    {
        private Lista_Notas_Debitos debito;

        protected void Page_Load(object sender, EventArgs e)
        {
            /*
            if (!Page.IsPostBack) {
                try
                {
                    var dir = Server.MapPath("/Data");
                    var file = Path.Combine(dir, ConfigurationManager.AppSettings["FileDebito"]);

                    debito = new Lista_Notas_Debitos(file);
                    Nota_Debito factura = new Nota_Debito(" guillermo ", " pablo ", 3000, "fragil producto", "12/12/2016");

                    debito.AñadirRegistro(factura);

                    Nota_Debito facturaMuestra = debito.LeerRegistro(0);
                    lblTexto.Text = facturaMuestra.Remitente + " " + facturaMuestra.Destinatario;
                }
                catch (Exception ex) {
                    // mostrar mensaje de error
                }                
            }*/

            if (!Page.IsPostBack)
            {
                try
                {
                    var dir = Server.MapPath("/Data");
                    var file = Path.Combine(dir, ConfigurationManager.AppSettings["FileDebito"]);

                    debito = new Lista_Notas_Debitos(file);

                    var l = new List<Nota_Debito>();
                    for (var i = 0; i < debito.NumeroRegistro(); i++)
                    { 
                        Nota_Debito facturaMuestra = debito.LeerRegistro(i);
                        l.Add(facturaMuestra);
                    }

                    GridView1.DataSource = l;
                    GridView1.DataBind();
                    
                    //lblTexto.Text = facturaMuestra.Remitente + " " + facturaMuestra.Destinatario;
                }
                catch (Exception ex)
                {
                    // mostrar mensaje de error
                }
            }
        }
    }
}
