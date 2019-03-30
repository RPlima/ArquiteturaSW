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
        //private readonly IMovelDAL Imovel;
        //private readonly IEstiloDAL Iestilo;

        //private HomeController(IEstiloDAL Iestilo, IMovelDAL Imovel)
        //{
        //    this.Iestilo = Iestilo;
        //    this.Imovel =Imovel;
        //}

        public ActionResult Index()
        {
            //ViewBag.EstiloId = new SelectList(Iestilo.BuscarEstilos(), "IdEstilo", "NomeEstilo");
            //ViewBag.MovelId = new SelectList(Imovel.BuscarMoveis(), "IdMovel", "NomeMovel");
            return View();
        }
    }
}