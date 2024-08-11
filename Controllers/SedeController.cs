using Munipocollay_InformesTecnicos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Munipocollay_InformesTecnicos.Controllers
{
    public class SedeController : Controller
    {
        private Sede objsede = new Sede();

        public ActionResult Index(string criterio)
        {
            if (criterio == null || criterio == "")
            {
                return View(objsede.Listar());
                {

                };
            }
            else
            {
                return View(objsede.Buscar(criterio));
            }
        }

        //Ver_Categoria
        public ActionResult Ver(int id)
        {
            return View(objsede.Obtener(id));

        }

        //Buscar_Categoria
        public ActionResult Buscar(string criterio)
        {
            return View(criterio == null || criterio == "" ? objsede.Listar() : objsede.Buscar(criterio));

        }

        //Editar_Categoria
        public ActionResult AgregarEditar(int id = 0)
        {
            return View(
                id == 0 ? new Sede()
                : objsede.Obtener(id));

        }


        //Guardamos_Categoria
        public ActionResult Guardar(Sede objsede)
        {
            if (ModelState.IsValid)
            {
                objsede.Guardar();
                TempData["AlertarGuardar"] = "Se registro se agrego correctamente"; //Alerta de guardado

                return Redirect("~/Sede/Index");

            }
            else
            {
                return View("~/Views/Sede/AgregarEditar.cshtml");
            }

        }


        //Eliminamos_Categoria
        public ActionResult Eliminar(int id)
        {
            objsede.SedeID = id;
            objsede.Eliminar();
            TempData["AlertarEliminar"] = "El registro se Elimino correctamente"; //Alerta de eliminado

            return Redirect("~/Sede/Index");
        }
    }
}