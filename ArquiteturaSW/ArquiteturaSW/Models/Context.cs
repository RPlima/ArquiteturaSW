using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ArquiteturaSW.Models
{
    public class Context : DbContext
    {
        public Context() : base("DBArquiteturaSW") { }

        public DbSet<Movel> Moveis { get; set; }
        public DbSet<Estilo> Estilos { get; set; }



    }
}