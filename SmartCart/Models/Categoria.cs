using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartCart.Models
{
    [Table("Categorias")]
    public class Categoria
    {
        [Key]
        public int CategoriaId { get; set; }

        [StringLength(100,ErrorMessage ="O tamanho maximo é 100 Caracteres")]
        [Required(ErrorMessage ="Informe o nome da Categoria")]
        [Display(Name = "Nome Categoria")] 
        public string CatergoriaNome { get; set; }

        [StringLength(200, ErrorMessage = "O tamanho maximo é 200 Caracteres")]
        [Required(ErrorMessage = "Informe o Descrição da Categoria")]
        [Display(Name = "Descrição Categoria")] 
        public string CategoriaDescricao { get; set; }

        public List<Produto> Produtos { get; set; }
    }
}
