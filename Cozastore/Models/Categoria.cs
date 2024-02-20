using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Cozastore.Models;
[Table("Categoria")]
public class Categoria
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required(ErrorMessage = "Por favor, informe o Nome")]
    [StringLength(30, ErrorMessage = "O Nome deve possuir 30 caracteres")]
    public string Nome {get; set; }

    [Display(Name = "Código Hexa", Prompt = "Ex. #FEFEFE")]
    [Required(ErrorMessage = "Por favor, informe o Código Hexa")]
    [StringLength(30, ErrorMessage = "O Código Hexa deve possuir 30 caracteres")]
    public string CodigoHexa {get; set; }

}