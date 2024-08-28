using Munipocollay_InformesTecnicos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Munipocollay_InformesTecnicos.Controllers

{
    [Authorize]
    public class AreaController : Controller
    {
        private Area objarea = new Area();

        public ActionResult Index(string criterio)
        {
            if (criterio == null || criterio == "")
            {
                return View(objarea.Listar());
                {

                };
            }
            else
            {
                return View(objarea.Buscar(criterio));
            }
        }

        //Ver_Area
        public ActionResult Ver(int id)
        {
            return View(objarea.Obtener(id));

        }

        //Buscar_Area
        public ActionResult Buscar(string criterio)
        {
            return View(criterio == null || criterio == "" ? objarea.Listar() : objarea.Buscar(criterio));

        }

        //Editar_Area
        public ActionResult AgregarEditar(int id = 0)
        {
            return View(
                id == 0 ? new Area()
                : objarea.Obtener(id));

        }


        //Guardamos_Area
        public ActionResult Guardar(Area objarea)
        {
            if (ModelState.IsValid)
            {
                objarea.Guardar();
                TempData["AlertarGuardar"] = "Se registro se agrego correctamente"; //Alerta de guardado

                return Redirect("~/Area/Index");

            }
            else
            {
                return View("~/Views/Area/AgregarEditar.cshtml");
            }

        }


        //Eliminamos_Area
        public ActionResult Eliminar(int id)
        {
            objarea.AreaID = id;
            objarea.Eliminar();
            TempData["AlertarEliminar"] = "El registro se Elimino correctamente"; //Alerta de eliminado

            return Redirect("~/Area/Index");
        }
    }
}