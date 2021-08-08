using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

//el name space es el nombre del proyecto, mas la carpeta controllers...
namespace CursoDeIntroduccionMVC.Controllers
{
    public class InicioController : Controller // el nombre del controlador es el controlador, mas la palabra controller, y
        // especificamos que hereda de la clase controller.
    {
        //los metodos de tipo action result son los que nos permiten retornar las vistas que tengan el mismo nombre del metodo...
        //en este caso este action result esta llamando a la vista Index que se encuentra en la carpet Home de las vistas Views
        public ActionResult Index()
        {
            //los actionResult siempre devuelven un tipo ActionResult en el metodo View();
            return View();
        }

        public ActionResult Acercade()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contactos()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Mision()
        {
            return View();
        }
    }
}