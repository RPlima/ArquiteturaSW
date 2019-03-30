using ArquiteturaSW.DAL.Interfaces;
using ArquiteturaSW.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ArquiteturaSW.DAL
{
    public class MovelDAL : IMovelDAL
    {

        private readonly Context ctx = Singleton.Singleton.GetInstance();
        public List<Movel> BuscarMoveis()
        {
            return ctx.Moveis.ToList();
        }

        public Movel BuscarMovel(int id)
        {
            return ctx.Moveis.FirstOrDefault(x => x.IdMovel == id);
        }
    }
}