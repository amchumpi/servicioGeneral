using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicioGeneral.Models
{
    public class Credenciales
    {
        public Credenciales()
        {
            Usuario = "";
            Password = "";
        }

        public string Usuario { get; set; }
        public string Password { get; set; }
    }
}
