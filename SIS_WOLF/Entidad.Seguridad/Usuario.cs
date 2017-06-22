using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad.Seguridad
{
    public class Usuario
    {
        public Usuario(int id, String user, String password){
            this.id = id;
            this.user = user;
            this.password = password;
        }
        public int id { get; set; }
        public String user { get; set; }
        public String password { get; set; }
    }
}
