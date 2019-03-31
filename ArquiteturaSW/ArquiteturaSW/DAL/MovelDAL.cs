using ArquiteturaSW.DAL.Interfaces;
using ArquiteturaSW.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ArquiteturaSW.DAL
{
    public class MovelDAL 
    {

        private static readonly Context ctx = Singleton.Singleton.GetInstance();
        public static List<Movel> BuscarMoveis()
        {
            return ctx.Moveis.ToList();
        }

        public static Movel BuscarMovel(int id)
        {
            return ctx.Moveis.FirstOrDefault(x => x.IdMovel == id);
        }

        public static Movel BuscarMovelPorEstiloETipo(int IdEstilo, int IdTipo)
        {
            return ctx.Moveis.Where(x =>  x.IdTipo == IdTipo && x.IdEstilo == IdEstilo).FirstOrDefault();
        }
    }
}