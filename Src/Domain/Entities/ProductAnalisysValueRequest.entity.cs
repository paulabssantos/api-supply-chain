using System.ComponentModel.DataAnnotations;

public class ProductAnalisysValueRequest
{
    [Required(ErrorMessage = "Id do produto é obrigatório")]
    public int ProductId { get; set; }

    public virtual Product Product { get; set; }

    [Required(ErrorMessage = "Quantidade do produto a ser analisado é obrigatória")]
    public int Quantity { get; set; }
}