using System.Web.Mvc;
using PrimeiraAPP_MVC4.Models;

namespace PrimeiraAPP_MVC4.Controllers
{
    public class UsuarioController : Controller
    {
        //
        // GET: /Usuario/

        private static Usuarios _usuarios = new Usuarios();

        public ActionResult Index()
        {
            return View( _usuarios.listaUsuarios);
        }

        public ActionResult AdicionaUsuario()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AdicionaUsuario(UsuarioModel _usuarioModel)
        {
            _usuarios.CriaUsuario(_usuarioModel);
            return View();
        }
    }
}
