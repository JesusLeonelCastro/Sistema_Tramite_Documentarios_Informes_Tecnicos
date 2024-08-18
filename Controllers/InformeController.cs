using iText.Kernel.Pdf;
using iText.Layout.Element;
using iText.StyledXmlParser.Jsoup.Nodes;
using Munipocollay_InformesTecnicos.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;

using System.Web.Mvc;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;


namespace Munipocollay_InformesTecnicos.Controllers
{
    public class InformeController : Controller
    {
        private Informes objinformes = new Informes();

        private Falla objfalla = new Falla();

        private O_Actividades objo_Actividades = new O_Actividades();

        private Sede objsede = new Sede();

        private Tipo_Equipo objtipo_equipso = new Tipo_Equipo();

        private Estados objestado = new Estados();

        private Equipo objequipo = new Equipo();

        private Area objarea = new Area();



        public ActionResult Index(string criterio)
        {
            var area = objarea.Listar();
            ViewBag.area = objarea;

            var falla = objfalla.Listar();
            ViewBag.falla = falla;

            var o_Actividades = objo_Actividades.Listar();
            ViewBag.o_Actividades = o_Actividades;

            var sede = objsede.Listar();
            ViewBag.sede = sede;

            var tipo_equipo = objtipo_equipso.Listar();
            ViewBag.tipo_equipo = tipo_equipo;

            var estado = objestado.Listar();
            ViewBag.estado = estado;

            var equipo = objequipo.Listar();
            ViewBag.equipo = equipo;


            if (criterio == null || criterio == "")
            {
                return View(objinformes.Listar());


            }
            else
            {
                return View(objinformes.Buscar(criterio));
            }


        }

        //Ver_Articulo
        public ActionResult Ver(int id)
        {
            return View(objinformes.Obtener(id));
        }

        //Buscar_Articulo
        public ActionResult Buscar(string criterio)
        {
            return View(criterio == null || criterio == "" ? objinformes.Listar() : objinformes.Buscar(criterio));

        }

        //Editar_Artoculo
        public ActionResult AgregarEditar(int id = 0)
        {

            // Cargar listas para los dropdowns en la vista
            ViewBag.Tipo = new Area().Listar();
            ViewBag.Tipo4 = new Falla().Listar();
            ViewBag.Tipo2 = new Sede().Listar();
            ViewBag.Tipo3 = new Tipo_Equipo().Listar();
            ViewBag.Tipo6 = new O_Actividades().Listar();
            ViewBag.Tipo7 = new Estados().Listar();
            ViewBag.Tipo5 = new Equipo().Listar();

            // Crear una instancia del modelo
            Informes model;

            if (id == 0)
            {
                // Si es un nuevo informe, asigna el valor predeterminado al título
                model = new Informes
                {
                    Titulo = "FORMATO DE INFORME TECNICO DE SOPORTE INFORMATICO 2024"
                };
            }
            else
            {
                // Si se está editando un informe existente, carga el informe de la base de datos
                model = new Informes().Obtener(id);
            }

            return View(model);

        }

        //Guardar_Articulo
        public ActionResult Guardar(Informes objinformes)
        {
            if (ModelState.IsValid)
            {
                objinformes.Guardar();
                TempData["AlertarGuardar"] = "El registro se guardó correctamente"; // Alerta de guardado
                return Redirect("~/Informe/Index");
            }
            else
            {
                ViewBag.Tipo = new Area().Listar(); // Asegúrate de que este método devuelva todas las categorías
                ViewBag.Tipo = new Falla().Listar(); // Asegúrate de que este método devuelva todas las categorías
                ViewBag.Tipo = new Sede().Listar(); // Asegúrate de que este método devuelva todas las categorías
                ViewBag.Tipo = new Tipo_Equipo().Listar(); // Asegúrate de que este método devuelva todas las categorías
                ViewBag.Tipo = new O_Actividades().Listar(); // Asegúrate de que este método devuelva todas las categorías
                ViewBag.Tipo = new Estados().Listar(); // Asegúrate de que este método devuelva todas las categorías
                ViewBag.Tipo = new Equipo().Listar(); // Asegúrate de que este método devuelva todas las categorías

                return View("~/Views/Informe/AgregarEditar.cshtml", objinformes);
            }
        }

        //Eliminamos_Articulo
        public ActionResult Eliminar(int id)
        {
            objinformes.InformeID = id;
            objinformes.Eliminar();
            TempData["AlertarEliminar"] = "El registro se elimino correctamente"; //Alerta de eliminado

            return Redirect("~/Informe/Index");
        }




        //Generar_Informe_Tecnico PDF
        private Model1 db = new Model1();

        public ActionResult GenerarPDF(int informeID)
        {
            // Obtener los datos del informe según el ID
            var informe = ObtenerInformePorID(informeID);

            if (informe == null)
            {
                return HttpNotFound();
            }

            iTextSharp.text.Document document = new iTextSharp.text.Document();
            MemoryStream memoryStream = new MemoryStream();
            iTextSharp.text.pdf.PdfWriter writer = iTextSharp.text.pdf.PdfWriter.GetInstance(document, memoryStream);
            document.Open();

            document.Add(new iTextSharp.text.Paragraph("Título del Informe: " + informe.Titulo + " - "+ informeID));
            document.Add(new iTextSharp.text.Paragraph("Tipo Equipo: " + informe.Tipo_Equipo.Nombre));
            document.Add(new iTextSharp.text.Paragraph("Area: " + informe.Area.Nombre_Area));
            document.Add(new iTextSharp.text.Paragraph("Sede: " + informe.Sede.Nombre_Sede));
            document.Add(new iTextSharp.text.Paragraph("Fallas Reportadas: " + informe.Falla.Nombre_Falla));
            document.Add(new iTextSharp.text.Paragraph("Otras Actividades: " + informe.O_Actividades.Nombre_O_Actividad));
            document.Add(new iTextSharp.text.Paragraph("Fecha Solicitada: " + informe.Fecha_Solicitud));
            document.Add(new iTextSharp.text.Paragraph("Fecha Informe: " + informe.Fecha_Informe));
            document.Add(new iTextSharp.text.Paragraph("diagnostico: " + informe.Diagnostico));


            document.Add(new iTextSharp.text.Paragraph("Nombre Equipo: " + informe.Nombre_Equipos));
            document.Add(new iTextSharp.text.Paragraph("Tipo Equipo: " + informe.Tipo_Equipo.Nombre));
            document.Add(new iTextSharp.text.Paragraph("Color: " + informe.Color));
            document.Add(new iTextSharp.text.Paragraph("N.Serie: " + informe.Serie));
            document.Add(new iTextSharp.text.Paragraph("Codigo Patrimonial: " + informe.Cod_Patrimonial));
            document.Add(new iTextSharp.text.Paragraph("Modelo: " + informe.Modelo));
            document.Add(new iTextSharp.text.Paragraph("Marca: " + informe.Marca));
            document.Add(new iTextSharp.text.Paragraph("Codigo Interno: " + informe.Codigo_Interno));
            document.Add(new iTextSharp.text.Paragraph("Observaciones: " + informe.Observaciones));


            document.Close();
            writer.Close();

            byte[] pdfBytes = memoryStream.ToArray();
            return File(pdfBytes, "application/pdf", informe.Titulo + " - "+ informeID + ".pdf");
        }

        private Informes ObtenerInformePorID(int informeID)
        {
           
            return db.Informes.Find(informeID);
        }


    }
}