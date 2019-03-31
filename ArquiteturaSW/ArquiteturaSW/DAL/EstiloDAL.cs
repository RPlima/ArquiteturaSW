using ArquiteturaSW.DAL.Interfaces;
using ArquiteturaSW.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ArquiteturaSW.DAL
{
    public class EstiloDAL 
    {
        private static readonly Context ctx =  Singleton.Singleton.GetInstance();

        public static Estilo BuscarEstilo(int id)
        {
            return ctx.Estilos.FirstOrDefault(x => x.IdEstilo == id);
        }

        public static List<Estilo> BuscarEstilos()
        {
            return ctx.Estilos.ToList();
        }


    }
}