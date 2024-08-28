﻿using Munipocollay_InformesTecnicos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Munipocollay_InformesTecnicos.Controllers
{
    public class AutenticationController : Controller
    {
        // GET: Autentication
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]

        public ActionResult Index(Usuario Usuario, string ReturnUrl)
        {
            HomeController obj = new HomeController();

            if (IsValid(Usuario))
            {
                Session["Usuarios"] = Usuario.UsuarioID;

                FormsAuthentication.SetAuthCookie(Usuario.DNI, false);

                //Para mostar Nombre y Apellido en el _Layout.cshtml
                ViewBag.NombreCompleto = Usuario.Nombre_Usuario + " " + Usuario.Apellido_Usuario;

                if (ReturnUrl != null)
                {
                    return Redirect(ReturnUrl);
                }
                return RedirectToAction("Index", "Home");

            }
            TempData["mensaje"] = "ERROR : El Numero Documento o contraseña que ingresaste no está correcto a verifique bien sus dato.";

            return RedirectToAction("Login");

        }


        private bool IsValid(Usuario usuarios)
        {

            return usuarios.Autenticar();
        }

        public ActionResult LogOut()
        {

            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("Index", "Login");
        }
    }
}