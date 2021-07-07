using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspMax.Models
{
    public class Categoria
    {
        public int id { get; set; }
        public string descricao { get; set; }

        public List<Produto> Produtos { get; set; }
    }
}
