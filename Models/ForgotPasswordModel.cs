using System.ComponentModel.DataAnnotations;

namespace JMA.Models
{
    public class ForgotPasswordModel
    {
        [Required(ErrorMessage = "El correo es obligatorio")]
        [EmailAddress(ErrorMessage = "Ingrese un correo válido")]
        public string Email { get; set; }
    }
}
