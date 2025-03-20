using System;
using System.ComponentModel.DataAnnotations;

namespace JMA.Models
{
    public class Paciente
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio.")]
        [StringLength(100, ErrorMessage = "El nombre no puede tener más de 100 caracteres.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "La ubicación es obligatoria.")]
        [StringLength(200, ErrorMessage = "La ubicación no puede tener más de 200 caracteres.")]
        public string Ubicacion { get; set; }

        [Required(ErrorMessage = "La fecha de egreso es obligatoria.")]
        public DateTime FechaEgreso { get; set; }

        [Required(ErrorMessage = "La deuda es obligatoria.")]
        [Range(0, double.MaxValue, ErrorMessage = "La deuda debe ser un valor positivo.")]
        public decimal Deuda { get; set; }

        [Required(ErrorMessage = "El género es obligatorio.")]
        public string Genero { get; set; }

        [Required(ErrorMessage = "La edad es obligatoria.")]
        [Range(0, 120, ErrorMessage = "La edad debe estar entre 0 y 120 años.")]
        public int Edad { get; set; }

        [Required(ErrorMessage = "El teléfono es obligatorio.")]
        [Phone(ErrorMessage = "El teléfono no es válido.")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "El email es obligatorio.")]
        [EmailAddress(ErrorMessage = "El correo electrónico no es válido.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "La dirección es obligatoria.")]
        [StringLength(500, ErrorMessage = "La dirección no puede tener más de 500 caracteres.")]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "El estado de salud es obligatorio.")]
        public string EstadoSalud { get; set; }

        [Required(ErrorMessage = "La fecha de ingreso es obligatoria.")]
        public DateTime FechaIngreso { get; set; }
    }
}
