using Site01.Library.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Site01.Models
{
    public class Palavra
    {        
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo 'Nome' é obrigatório!")]
        [MaxLength(50, ErrorMessage = "Máximo de 50 caracteres!")]
        // [UnicoNomePalavra]   // Não está liberando a função atualizar
        public string Nome { get; set; }


        public byte? Nivel { get; set; }
    }
}
