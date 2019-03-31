using ArquiteturaSW.DAL;
using ArquiteturaSW.DAL.Interfaces;
using ArquiteturaSW.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ArquiteturaSW.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            ViewBag.IdEstilo = new SelectList(EstiloDAL.BuscarEstilos(), "IdEstilo", "NomeEstilo");
            ViewBag.IdTipo = new SelectList(TipoDAL.BuscarTipos(), "IdTipo", "NomeTipo");
            ViewBag.EstadoImage = false;
            return View();
        }

        [HttpPost]
        public ActionResult Index(int IdEstilo, int IdTipo)
        {
            ViewBag.EstadoImage = true;
            ViewBag.IdEstilo = new SelectList(EstiloDAL.BuscarEstilos(), "IdEstilo", "NomeEstilo");
            ViewBag.IdTipo = new SelectList(TipoDAL.BuscarTipos(), "IdTipo", "NomeTipo");

            return View(MovelDAL.BuscarMovelPorEstiloETipo(IdEstilo,IdTipo));
        }
    }
}