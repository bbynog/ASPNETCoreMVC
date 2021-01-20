using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Site01.Models
{
    public class Usuario
    {
        [Required(ErrorMessage = "O campo 'Email' é obrigatório!")]
        [EmailAddress(ErrorMessage = "O formato de email está errado.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo 'Senha' é obrigatório!")]        
        
        public string Senha { get; set; }
    }
}
