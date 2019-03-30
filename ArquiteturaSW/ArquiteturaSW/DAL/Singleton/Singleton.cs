using ArquiteturaSW.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ArquiteturaSW.DAL.Singleton
{
    public class Singleton
    {
        private static Context _context;

        private Singleton()
        {

        }
        public static Context GetInstance()
        {
            if (_context == null)
                _context = new Context();

            return _context;
        }
    }
}