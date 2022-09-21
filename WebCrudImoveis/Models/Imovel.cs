using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebCrudImoveis.Models
{
    [Table("Imoveis")]
    public class Imovel
    {
        [Column("Id")]
        [Display(Name ="Código")]
        public int Id { get; set; }

        [Column("Nome")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Column("Categoria")]
        [Display(Name = "Categoria")]
        public string Categoria { get; set; }

        [Column("Preco")]
        [Display(Name = "Preco")]
        public decimal Preco { get; set; }

        [Column("Endereco")]
        [Display(Name = "Endereco")]
        public string Endereco { get; set; }
    }
}
