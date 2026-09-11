using System.ComponentModel.DataAnnotations;

namespace VaultContactos.Models
{
    public class Contacto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo Nombre es requerido.")]
        [RegularExpression(@"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s]+$", ErrorMessage = "El nombre solo debe contener letras.")]
        [StringLength(50, ErrorMessage = "El nombre no puede superar los 50 caracteres.")]
        public string Nombre { get; set; } = string.Empty;

        [Required(ErrorMessage = "El campo Apellido es requerido.")]
        [RegularExpression(@"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s]+$", ErrorMessage = "El apellido solo debe contener letras.")]
        [StringLength(50, ErrorMessage = "El apellido no puede superar los 50 caracteres.")]
        public string Apellido { get; set; } = string.Empty;

        [Required(ErrorMessage = "El campo Teléfono es requerido.")]
        [RegularExpression(@"^\d+$", ErrorMessage = "El teléfono solo debe contener números.")]
        [StringLength(15, MinimumLength = 7, ErrorMessage = "El teléfono debe tener entre 7 y 15 dígitos.")]
        public string Telefono { get; set; } = string.Empty;

        [Required(ErrorMessage = "El correo electrónico es requerido.")]
        [EmailAddress(ErrorMessage = "Ingrese un correo electrónico válido.")]
        [RegularExpression(@"^[^@\s]+@[^@\s]+\.(com|org|net|edu|es|bo)$", ErrorMessage = "El correo debe tener un dominio válido (ej. .com, .net, .bo).")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "El campo Empresa es requerido.")]
        [StringLength(50, ErrorMessage = "La empresa no puede superar los 50 caracteres.")]
        public string Empresa { get; set; } = string.Empty;
    }
}