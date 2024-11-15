using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.DTO
{
    public class LoginDTO
    {
        [Required(ErrorMessage = "Confirme contraseña")]
        public string? Correo { get; set; }

        [Required(ErrorMessage = "Ingrese comtraseña")]
        public string? Clave { get; set; }
        
    }
}
