using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SimpressWeb.Models
{
    public class Produto
    {
        [Required(ErrorMessage ="O campo Nome é obrigatório.")]
        [StringLength(250, ErrorMessage = "O campo Nome deve conter no máxmimo {1} caracteres.")]
        public string Nome { get; set; }

        [Display(Name ="Descrição")]
        [Required(ErrorMessage = "O campo Descrição é obrigatório.")]
        [StringLength(250, ErrorMessage = "O campo Descrição deve conter no máxmimo {1} caracteres.")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "O campo Ativo é obrigatório.")]
        public bool Ativo { get; set; }

        [Display(Name ="Perecível")]
        [Required(ErrorMessage = "O campo Perecível é obrigatório.")]
        public bool Perecivel { get; set; }

        public int ID { get; set; }

        [Display(Name = "Categoria")]
        [Required(ErrorMessage = "O campo Categoria é obrigatório.")]
        public int CategoriaID { get; set; }

        public virtual Categoria Categoria { get ;set; }
        
    }
}
