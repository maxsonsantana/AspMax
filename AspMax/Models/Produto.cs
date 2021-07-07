using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspMax.Models
{
    public class Produto
    {
        public int Id { get; set; }

        [Display(Name ="Descrição")]
        [Required(ErrorMessage ="Campo Descrição Obrigatório!")]
        public string Descricao { get; set; }

        [Range(1, 1000, ErrorMessage = "Mínimo 1 máximo 10")]
        public int Quantidade { get; set; }

        [Display(Name = "Categoria")]
        public int CategoriaID { get; set; }
        public Categoria  Categoria { get; set; }

    }
}
