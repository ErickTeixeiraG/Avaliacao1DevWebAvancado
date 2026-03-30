using System.ComponentModel.DataAnnotations;

namespace ProdutosApi;

public class Produto
{
    public int Id {get; set;}

    [Required(ErrorMessage = "O nome é obrigatório")]
    [StringLength(120, MinimumLength = 3, ErrorMessage = "O nome deve ter entre 3 e 120 caracteres.")]
    public string Nome {get; set;} = string.Empty;

    [Range(typeof(decimal),"0.01", "99999999999,99", ErrorMessage = "O Preço não pode ser negativo")]
    public decimal Preco {get; set;}

    [Range(1, int.MaxValue, ErrorMessage = "A quantidade em estoque tem que ser maior que zero")]
    public int Estoque {get; set;}
}