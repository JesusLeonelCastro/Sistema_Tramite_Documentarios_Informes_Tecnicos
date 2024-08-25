using Munipocollay_InformesTecnicos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Munipocollay_InformesTecnicos.Controllers
{
    public class UsuarioController : Controller
    {
        private Usuario objusuario = new Usuario();

        public ActionResult Index(string criterio)
        {
            if (criterio == null || criterio == "")
            {
                return View(objusuario.Listar());
                {

                };
            }
            else
            {
                return View(objusuario.Buscar(criterio));
            }
        }

        //Ver_Usuario
        public ActionResult Ver(int id)
        {
            return View(objusuario.Obtener(id));

        }

        //Buscar_Usuario
        public ActionResult Buscar(string criterio)
        {
            return View(criterio == null || criterio == "" ? objusuario.Listar() : objusuario.Buscar(criterio));

        }

        //Editar_Usuario
        public ActionResult AgregarEditar(int id = 0)
        {
            return View(
                id == 0 ? new Usuario()
                : objusuario.Obtener(id));

        }


        //Guardamos_Usuario
        public ActionResult Guardar(Usuario objusuario)
        {
            if (ModelState.IsValid)
            {
                objusuario.Guardar();
                TempData["AlertarGuardar"] = "Se registro se agrego correctamente"; //Alerta de guardado

                return Redirect("~/Usuario/Index");

            }
            else
            {
                return View("~/Views/Usuario/AgregarEditar.cshtml");
            }

        }


        //Eliminamos_Usuario
        public ActionResult Eliminar(int id)
        {
            objusuario.UsuarioID = id;
            objusuario.Eliminar();
            TempData["AlertarEliminar"] = "El registro se Elimino correctamente"; //Alerta de eliminado

            return Redirect("~/Usuario/Index");
        }
    }
}