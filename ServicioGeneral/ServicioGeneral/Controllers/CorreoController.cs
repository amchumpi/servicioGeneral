using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicioGeneral.Controllers
{
    [Route("api/[controller]")]
    public class CorreoController : Controller
    {
        // GET: CorreoController
        [HttpGet]
        public void  EnviarCorreo(Models.Credenciales credenciales, Models.Email correo)
        {
            Utiles.GestionCorreo gestionCorreo = null;
            try
            {                
                gestionCorreo = new Utiles.GestionCorreo();
                gestionCorreo.SendEmail(credenciales, correo);                
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo enviar Correo[ReglasCorreo].\nError:" + ex.Message, ex);
            }
            finally
            {
                gestionCorreo = null;
            }
        }

        
    }
}
