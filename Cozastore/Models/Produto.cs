using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cozastore.Models;

[Table("Produto")]
public class Produto
{

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required(ErrorMessage = "Por favor, informe o Nome")]
    [StringLength(100, ErrorMessage = "O Nome deve possuir 100 caracteres")]
    public string Nome {get; set; }

    [Display(Name = "Descrição Resumida")]
    [StringLength(1000, ErrorMessage = "A Descrição Resumida deve possuir 1000 caracteres")]
    public string DescricaoResumida { get; set; }

    [Display(Name = "Descrição Resumida")]
    [StringLength(8000, ErrorMessage = "A Descrição Completa deve possuir 8000 caracteres")]
    public string DescricaoCompleta { get; set; }

    [StringLength(10, ErrorMessage = "A SKU deve possuir 10 caracteres")]
    public string SKU { get; set; }

    [Display(Name = "Preço")]
    [Column(TypeName = "decimal(10,2)")]
    [Required(ErrorMessage = "Por favor, informe o Preço de Venda")]
    public decimal Preco { get; set;}

    [Display(Name = "Preço com Desconto")]
    [Column(TypeName = "decimal(10,2)")]
    public decimal PrecoDesconto { get; set;}

    [Display(Name = "Preço com Destaque?")]
    public bool Destaque { get; set; }

    [Column(TypeName = "decimal(8,3)")]
    public decimal Peso { get; set; }

    [StringLength(30, ErrorMessage = "O Material deve possuir 30 caracteres")]
    public string Material { get; set; }

    [Display(Name = "Dimensão")]
    [StringLength(30, ErrorMessage = "A Dimensão deve possuir 30 caracteres")]
    public string Dimensao { get; set; }

    [Display(Name = "Categoria")]
    [Required(ErrorMessage = "Por favor, informe a Categoria")]
    public int CategoriaId { get; set; }

    [ForeignKey("CategoriaId")]
    public Categoria Categoria { get; set; }
}

