using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ConchApp1.Models
{
    public class Puntacion
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public int Puntaje { get; set; }

        [Required]
        public string Comentario { get; set; }

        [Required]
        public int IdTransportista { get; set; }

        [Required]
        public int IdPasajero { get; set; }

        [Required]
        public DateTime Fecha { get; set; }

        [ForeignKey("IdPasajero")]
        public virtual UsuarioPasajero UsuarioPasajero { get; set; }

        [ForeignKey("IdTransportista")]
        public virtual UsuariosTransportistas UsuariosTransportistas { get; set; }
    }
}