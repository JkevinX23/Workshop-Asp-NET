using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FilmesCRUDRazor.Models
{
    public class Filme
    {
        public int FilmeId { get; set; }

        [Display(Name="Título")]
        [Required(ErrorMessage = "Título obrigatório")]
        
        public string Titulo { get; set; }


        [Display(Name="Data de Lançamento")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}")]
        [Required(ErrorMessage = "Data de lançamento é um campo obrigatório")]

        public DateTime DataLancamento { get; set; }
        
         
        [Display(Name="Gênero")]
        [Required(ErrorMessage = "É obrigatório informar o gênero do filme")]
        public string Genero { get; set; }

        [Display(Name="Preço")]
        [DataType(DataType.Currency, ErrorMessage="Valor inválido.")]
        public decimal Preco { get; set; }
    }
}