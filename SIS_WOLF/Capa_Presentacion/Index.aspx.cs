using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidad.Seguridad;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

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

        [WebMethod]
        public static object getUsers()
        {
            List<Usuario> lista = new List<Usuario>();
            lista.Add(new Usuario(1, "Jorge", "456"));
            lista.Add(new Usuario(2, "Amelia", "741"));
            lista.Add(new Usuario(3, "Geovanny", "9863"));
            lista.Add(new Usuario(4, "Petter", "423"));
            lista.Add(new Usuario(5, "Pepe", "758"));
            lista.Add(new Usuario(6, "Julio", "123"));
            //string json = JsonConvert.SerializeObject(lista);            
            object json = new { data = lista};

            return json;
        }
    }
}