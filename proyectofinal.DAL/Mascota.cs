using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace proyectofinal.DAL
{
    public class Mascota
    {
        [Key]
        public int MascotaId { get; set; }

        [Required(ErrorMessage = "El nombre de la mascota es obligatorio.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El tipo de mascota es obligatorio.")]
        public string Tipo { get; set; }

        [Required(ErrorMessage = "La raza de la mascota es obligatoria.")]
        public string Raza { get; set; }

        public string Genero { get; set; }
        public int Edad { get; set; }
        public double Peso { get; set; }

        [ForeignKey("Cliente")]
        public int ClienteId { get; set; }

        public Cliente? Cliente { get; set; }
    }
}
