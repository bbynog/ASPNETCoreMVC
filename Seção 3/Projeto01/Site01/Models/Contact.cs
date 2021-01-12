using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Site01.Models
{
    public class Contact
    {
        [Required(ErrorMessage = "O campo 'Nome' é obrigatório!")]
        [MaxLength(50, ErrorMessage = "Máximo de 50 caracteres!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo 'Email' é obrigatório!")]
        [MaxLength(70, ErrorMessage = "Máximo de 70 caracteres!")]
        [EmailAddress(ErrorMessage = "O email não está em um formato válido.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo 'Assunto' é obrigatório!")]
        [MaxLength(70, ErrorMessage = "Máximo de 70 caracteres!")]
        public string Assunto { get; set; }

        [Required(ErrorMessage = "O campo 'Mensagem' é obrigatório!")]
        [MaxLength(2000, ErrorMessage = "Máximo de 2000 caracteres!")]
        public string Mensagem { get; set; }

    }
}
