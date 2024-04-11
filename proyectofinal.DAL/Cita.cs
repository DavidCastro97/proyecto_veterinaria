using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace proyectofinal.DAL
{
    public class Cita
    {
        [Key]
        public int CitaId { get; set; }

        [Required(ErrorMessage = "La fecha y hora de la cita son obligatorias.")]
        public DateTime FechaHora { get; set; }

        public string Descripcion { get; set; }
        public string Diagnostico { get; set; }
        public string Estado { get; set; }

        [ForeignKey("Mascota")]
        public int MascotaId { get; set; }

        public Mascota? Mascota { get; set; }
    }
}
