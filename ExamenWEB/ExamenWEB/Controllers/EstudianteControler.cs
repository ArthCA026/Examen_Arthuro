using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ExamenWEB.Models;

namespace ExamenWEB.Controllers
{
    public class UsuarioController : Controller
    {
        UsuarioModel model = new UsuarioModel();

        [HttpPost]
        public ActionResult AgregarMatricula()
        {
            var datos = model.AgregarMatricula
            return View(datos);
        }

    }
}