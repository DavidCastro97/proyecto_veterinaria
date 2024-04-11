using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace proyectofinal.DAL
{
    public class Cliente
    {
        [Key]
        public int ClienteId { get; set; }

        [Required(ErrorMessage = "El nombre del cliente es obligatorio.")]
        public string Nombre { get; set; }

        [EmailAddress(ErrorMessage = "Ingrese una dirección de correo electrónico válida.")]
        public string Email { get; set; }


        public ICollection<Mascota> Mascotas { get; set; } = new List<Mascota>();
    }
}
