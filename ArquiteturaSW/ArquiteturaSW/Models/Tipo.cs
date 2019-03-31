using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ArquiteturaSW.Models
{
    [Table(name:"Tipo")]
    public class Tipo
    {
        [Key]
        public int IdTipo { get; set; }

        public string NomeTipo { get; set; }
    }
}