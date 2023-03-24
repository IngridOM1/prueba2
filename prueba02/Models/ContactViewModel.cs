using System.ComponentModel.DataAnnotations;

namespace TuProyecto.Models
{
    public class ContactViewModel
    {
        [Required(ErrorMessage = "El campo Nombre es obligatorio.")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "El campo Correo electrónico es obligatorio.")]
        [EmailAddress(ErrorMessage = "Ingrese un correo electrónico válido.")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "El campo Mensaje es obligatorio.")]
        public string? Message { get; set; }
    }
}