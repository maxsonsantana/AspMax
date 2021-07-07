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
        [Range(1, 10, ErrorMessage ="Mínimo 1 máximo 10 Caracteres")]
        public string Descricao { get; set; }
        public int Quantidade { get; set; }
        public int CategoriaID { get; set; }
        public Categoria  Categoria { get; set; }

    }
}
