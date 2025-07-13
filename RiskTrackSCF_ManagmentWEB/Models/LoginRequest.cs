using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace RiskTrackSCF_ManagmentWEB.Models
{
    public class LoginRequest
    {
        [Required(ErrorMessage = "El campo Email es obligatorio.")]
        [EmailAddress(ErrorMessage = "Formato de email inválido.")]
        public string Email { get; set; } = string.Empty;
        [Required(ErrorMessage = "El campo Email es obligatorio.")]
        public string Password { get; set; } = string.Empty;
    }
}
