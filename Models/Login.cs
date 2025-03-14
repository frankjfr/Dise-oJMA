using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace JMA.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "El usuario es obligatorio")]
        public string Usuario { get; set; }

        [Required(ErrorMessage = "La contraseña es obligatoria")]
        [DataType(DataType.Password)]
        public string Clave { get; set; }

        [Required(ErrorMessage = "Debe seleccionar una empresa")]
        [Range(1, int.MaxValue, ErrorMessage = "Debe seleccionar una empresa válida")]
        public int EmpresaId { get; set; }

        public List<Empresa> Empresas { get; set; } = new List<Empresa>();
    }

    public class Empresa
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
    }
}
