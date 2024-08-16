using Munipocollay_InformesTecnicos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Web;
using System.Web.Mvc;

namespace Munipocollay_InformesTecnicos.Controllers
{
    public class HomeController : Controller
    {
        private Informes objinformes = new Informes();

        private Falla objfalla = new Falla();

        private O_Actividades objo_Actividades = new O_Actividades();

        private Sede objsede = new Sede();

        private Tipo_Equipo objtipo_equipso = new Tipo_Equipo();

        private Estados objestado = new Estados();

        private Equipo objequipo = new Equipo();

        private Area objarea = new Area();



        public ActionResult Index()
        {
            // Obtener el total de informes
            int totalInformes = objinformes.Listar().Count();
            ViewBag.TotalInformes = totalInformes;


            // Obtener el total de informes
            int totalAreas = objarea.Listar().Count();
            ViewBag.TotalAreas = totalAreas;



            // Obtener el total de informes agrupados por área
            var totalInformesPorArea = objinformes.Listar()
                .GroupBy(i => i.Area.Nombre_Area)
                .Select(group => new
                {
                    Nombre = group.Key,
                    Total = group.Count()
                }).ToList();

            ViewBag.TotalInformesPorArea = totalInformesPorArea;



            // Obtener el total de cada módulo
            int totalFallas = objfalla.Listar().Count();
            int totalActividades = objo_Actividades.Listar().Count();
            int totalSedes = objsede.Listar().Count();
            int totalTiposEquipo = objtipo_equipso.Listar().Count();
            int totalEstados = objestado.Listar().Count();
            int totalEquipos = objequipo.Listar().Count();

            // Pasar los totales a la vista
            ViewBag.TotalesPorModulo = new List<object>
            {
                new { Modulo = "Fallas", Total = totalFallas },
                new { Modulo = "Actividades", Total = totalActividades },
                new { Modulo = "Sedes", Total = totalSedes },
                new { Modulo = "Tipos de Equipo", Total = totalTiposEquipo },
                new { Modulo = "Estados", Total = totalEstados },
                new { Modulo = "Equipos", Total = totalEquipos },
                new { Modulo = "Áreas", Total = totalAreas }
            };


            return View();
        }


    }
}