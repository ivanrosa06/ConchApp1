using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ConchApp1.Models
{
    public class UsuariosTransportistas
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

        [Required]
        public int parada { get; set; }

        [Required]
        [StringLength(20)]
        public String Status { get; set; }

        [Required]
        [StringLength(40)]
        public string MarcaMotor { get; set; }

        [Required]
        [StringLength(20)]
        public string ColorMotor { get; set; }

        [Required]
        [StringLength(40)]
        public string Modelomotor { get; set; }

        [Required]
        [StringLength(15)]
        public string PlacaMotor { get; set; }

        [Required]
        [StringLength(50)]
        public string Contrasena { get; set; }


        [ForeignKey("parada")]
        public virtual Parada Parada { get; set; }
    }
}