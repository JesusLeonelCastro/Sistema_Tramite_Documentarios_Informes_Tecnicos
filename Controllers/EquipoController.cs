using Munipocollay_InformesTecnicos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Munipocollay_InformesTecnicos.Controllers
{
    public class EquipoController : Controller
    {
        private Equipo objequipo= new Equipo();



        public ActionResult Index(string criterio)
        {
            

            if (criterio == null || criterio == "")
            {
                return View(objequipo.Listar());
                {

                };
            }
            else
            {
                return View(objequipo.Buscar(criterio));
            }
        }

        //Ver_Equipo
        public ActionResult Ver(int id)
        {
            return View(objequipo.Obtener(id));

        }

        //Buscar_Equipo
        public ActionResult Buscar(string criterio)
        {
            return View(criterio == null || criterio == "" ? objequipo.Listar() : objequipo.Buscar(criterio));

        }

        //Editar_Equipo
        public ActionResult AgregarEditar(int id = 0)
        {

            return View(
                id == 0 ? new Equipo()
                : objequipo.Obtener(id));

        }


        //Guardamos_Equipo
        public ActionResult Guardar(Equipo objequipo)
        {
            if (ModelState.IsValid)
            {
                objequipo.Guardar();
                TempData["AlertarGuardar"] = "Se registro se agrego correctamente"; //Alerta de guardado

                return Redirect("~/Equipo/Index");

            }
            else
            {


                return View("~/Views/Equipo/AgregarEditar.cshtml");
            }

        }


        //Eliminamos_Equipo
        public ActionResult Eliminar(int id)
        {
            objequipo.EquipoID = id;
            objequipo.Eliminar();
            TempData["AlertarEliminar"] = "El registro se Elimino correctamente"; //Alerta de eliminado

            return Redirect("~/Equipo/Index");
        }
    }
}