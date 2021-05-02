using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SimpressWeb.Models
{
    public class Categoria
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        [StringLength(250, ErrorMessage = "O campo Nome deve conter no máxmimo {1} caracteres.")]
        public String Nome { get; set; }

        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "O campo Descrição é obrigatório.")]
        [StringLength(250, ErrorMessage = "O campo Descrição deve conter no máxmimo {1} caracteres.")]
        public String Descricao { get; set; }

        [Required(ErrorMessage = "O campo Ativo é obrigatório.")]
        public bool Ativo{ get; set; }

    }
}
