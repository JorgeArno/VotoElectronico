using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    public class Voto
    {
        [Key]
        public int ID { get; set; }       
        [Required]
        public string votosAlmacenados { get; set; }
    }
}
