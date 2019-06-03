using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ConchApp1.Models
{
    public class Parada
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(100)]
        public string Direccion { get; set; }

        [Required]
        [StringLength(50)]
        public string Administrador { get; set; }

        [Required]
        [StringLength(100)]
        public string Sindicato { get; set; }
    }
}