using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicioGeneral.Models
{
    public class Email
    {
        public Email()
        {
            De = "";
            Para = new List<string>();
            Cc = new List<string>();
            Bcc = new List<string>();
            Asunto = "";
            Mensaje = "";
            ConFormatoHtml = false;
        }

        public string De { get; set; }
        public List<string> Para { get; set; }
        public List<string> Cc { get; set; }
        public List<string> Bcc { get; set; }
        public string Asunto { get; set; }
        public string Mensaje { get; set; }
        public bool ConFormatoHtml { get; set; }


    }
}
