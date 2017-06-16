using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidad.Seguridad;
using Newtonsoft.Json.Linq;

namespace Capa_Presentacion
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [WebMethod]
        public static string Login(Usuario objUsuario)
        {
            string respuesta = "";
            respuesta = objUsuario != null ? "Bien" : "Mal";
            return respuesta;
        }
    }
}