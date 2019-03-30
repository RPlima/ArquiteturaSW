using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ArquiteturaSW.Models
{
    [Table(name:"Movel")]
    public class Movel
    {
        [Key]
        public int IdMovel { get; set; }

        [Required]
        public string NomeMovel { get; set; }

        public string Imagem { get; set; }

        public int IdEstilo { get; set; }

        public Estilo Estilo { get; set; }
    }
}