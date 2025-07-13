using System.ComponentModel.DataAnnotations;

namespace RiskTrackSCF_ManagmentWEB.Models
{
    public class CreateUserRequest
    {
        [Required(ErrorMessage = "La compañía es obligatoria.")]
        public int? CompanyId { get; set; }

        [Required(ErrorMessage = "El nombre de usuario es obligatorio.")]
        public string Username { get; set; } = string.Empty;

        [Required(ErrorMessage = "El email es obligatorio.")]
        [EmailAddress(ErrorMessage = "Formato de email inválido.")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "La contraseña es obligatoria.")]
        [MinLength(6, ErrorMessage = "Debe tener al menos 6 caracteres.")]
        public string Password { get; set; } = string.Empty;

        public string Role { get; set; } = "A"; 
    }
}


