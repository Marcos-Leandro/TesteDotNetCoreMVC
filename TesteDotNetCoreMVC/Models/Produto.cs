using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TesteDotNetCoreMVC.Models
{
    public class Produto
    {
        [Required(ErrorMessage = "Id obrigatório")]
        [Range(1, int.MaxValue, ErrorMessage = "Id minimo de 1")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Nome obrigatório")]
        [MinLength(4, ErrorMessage = "Minimo 4 letras")]
        [MaxLength(10, ErrorMessage = "Máximo 10 letras")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Preço obrigatório")]
        [Range(100,150, ErrorMessage = "Minino de 100 e máximo de 150")]
        public decimal Preco { get; set; }
        public string Descricao { get; set; }
    }
}
