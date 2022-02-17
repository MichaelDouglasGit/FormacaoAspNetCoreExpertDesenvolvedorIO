using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MinhaDemoMVC.Models
{
    public class Filme
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "O campo Título é obrigatório")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "O Título precisa ter entre 3 ou 60 caracteres")]
        public string Titulo {get; set;}
        
        [Required(ErrorMessage = "O campo Data é obrigatório")]
        [DataType(DataType.DateTime, ErrorMessage = "Data em formato incorreto")]
        [Display(Name = "Data de Lançamento")]
        public DateTime DataLancamento { get; set; }
        
        [RegularExpression(@"^[A-Z]+[a-zA-Z\u00C0-\u00FF""'\w-]*$", ErrorMessage = "Gênero em formato inválido")]
        [StringLength(30, ErrorMessage ="Máximo de 30 caracteres")]
        public string Genero { get; set; }
        
        [Range(1,1000, ErrorMessage = "Valor de 1 à 1000")]
        [Required(ErrorMessage = "Preencha o campo Valor")]
        [Column]
        public decimal Valor { get; set; }

        public string Avaliacao { get; set; }
    }
}