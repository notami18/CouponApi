using System.ComponentModel.DataAnnotations;

namespace Coupon.Api.Dtos
{
    public class UserForRegisterDto
    {
        [Display(Name = "Usuario")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Username { get; set; }

        [Display(Name = "Contraseña")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(8, MinimumLength = 4, ErrorMessage = "La contraseña debe ser entre 4 a 8 carateres")]
        public string Password { get; set; }
    }
}