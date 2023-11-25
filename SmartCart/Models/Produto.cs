using Microsoft.EntityFrameworkCore.Storage;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.ConstrainedExecution;

namespace SmartCart.Models
{
    [Table("Produtos")]
    public class Produto
    {
        [Key]
        public int ProdutoId { get; set; }

        [Required(ErrorMessage ="O nome do produto deve ser informado")]
        [Display(Name = "Nome do Produto")]
        [MinLength(2, ErrorMessage = "A descrição deve ter no minimo {2} caracter")]
        [MaxLengthAttribute(100, ErrorMessage = "A descrição deve ter no maximo {100} caracteres")]
        public string ProdutoNome { get; set; }
        
        [Required(ErrorMessage = "A Short Description do produto deve ser informada")]
        [Display(Name = "Short Description")]
        [MinLength(2, ErrorMessage ="A descrição deve ter no minimo {2} caracter")]
        [MaxLengthAttribute(100, ErrorMessage ="A descrição deve ter no maximo {100} caracteres")]
        public string ProdutoDescricaoCurta { get; set; }

        [Required(ErrorMessage = "A  descrição do produto deve ser informada")] 
        [Display(Name = "Descrição Completa")]
        public string ProdutoDescricaoCompleta { get; set; }

        [Required(ErrorMessage = "A  marca do produto deve ser informada")]
        [Display(Name = "Marca")]
        public string ProdutoMarca {  get; set; }

        [Required(ErrorMessage = "A  Cor do produto deve ser informada")] 
        [Display(Name = "Cor")]
        public string ProdutoCor { get; set; }

        [Required(ErrorMessage = "A  Pratica Esportiva do produto deve ser informada")]
        [Display(Name = "Pratica Esportiva")]
        public string ProdutoPraticaEsportiva { get; set; }


        [Required(ErrorMessage = "Material do produto deve ser informada")]
        [Display(Name = "Material")]
        public string ProdutoMaterial { get; set; }


        [Required(ErrorMessage = "O Preço do produto deve ser informada")] 
        [Display(Name = "Preço")]
        [Column(TypeName ="decimal(10,2)")]
        [Range(1,999.99, ErrorMessage ="O preço deve estar entre 1 e 999,99")]
        public decimal ProdutoPreco { get; set; }

        [Display(Name = "Caminho da Imagem Normal")]
        public string ImgUrl { get; set; }

        [Display(Name = "Caminho da Imagem Miniatura")]
        public string ImgThumbnaiUrl { get; set; }


        [Display(Name = "Favorito?")]
        public bool ProdutoFavorito { get; set; }


        [Display(Name = "Estoque")]
        public bool ProdutoAtivo { get; set; }
       

        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
        }
}

