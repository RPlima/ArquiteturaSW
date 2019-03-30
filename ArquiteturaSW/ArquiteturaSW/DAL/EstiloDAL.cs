using ArquiteturaSW.DAL.Interfaces;
using ArquiteturaSW.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ArquiteturaSW.DAL
{
    public class EstiloDAL : IEstiloDAL
    {
        private readonly Context ctx =  Singleton.Singleton.GetInstance();

        public Estilo BuscarEstilo(int id)
        {
            return ctx.Estilos.FirstOrDefault(x => x.IdEstilo == id);
        }

        public List<Estilo> BuscarEstilos()
        {
            return ctx.Estilos.ToList();
        }
    }
}