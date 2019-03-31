using ArquiteturaSW.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ArquiteturaSW.DAL
{
    public class TipoDAL
    {
        private static readonly Context ctx = Singleton.Singleton.GetInstance();
        public static List<Tipo> BuscarTipos()
        {
            return ctx.Tipos.ToList();
        }

        public static Tipo BuscarTipo(int id)
        {
            return ctx.Tipos.FirstOrDefault(x => x.IdTipo == id);
        }
    }
}