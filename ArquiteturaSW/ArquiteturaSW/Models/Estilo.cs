using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ArquiteturaSW.Models
{
    [Table(name:"Estilo")]
    public class Estilo
    {
        [Key]
        public int IdEstilo { get; set; }

        [Required]
        public string NomeEstilo { get; set; }

    }
}