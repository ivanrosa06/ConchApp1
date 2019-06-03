using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ConchApp1.Models
{
    public class UsuarioPasajero
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(11)]
        public string Cedula { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(50)]
        public string Apellido { get; set; }

        [Required]
        [StringLength(80)]
        public string Correo { get; set; }

        [Required]
        [StringLength(20)]
        public string Telefono { get; set; }
    }
}