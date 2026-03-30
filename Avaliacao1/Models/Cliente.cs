using System.ComponentModel.DataAnnotations;

namespace ProdutosApi;
public class Cliente
{
    public int Id {get; set;}

    [Required (ErrorMessage = "O nome é obrigayótio")]
    [StringLength(100, MinimumLength = 3, ErrorMessage = "O nome deve ter entre 3 e 100 caracteres.")]
    public string Nome {get; set;} = string.Empty;

    [Required(ErrorMessage = "O e-mail é obrigatório.")]
    [EmailAddress(ErrorMessage = "E-mail Inválido")]
    public string Email { get; set; } = string.Empty;

    [Required(ErrorMessage = "A idade é obrigatória.")]
    [Range(18, int.MaxValue, ErrorMessage = "A idade mínima é de 18 anos")]
    public int Idade{get; set;}
}