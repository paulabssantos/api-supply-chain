using System.ComponentModel.DataAnnotations;

public class PurchaseOrder
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "Status do pedido de compra é obrigatório")]
    public int Status { get; set; }
    public string? Justification { get; set; }
    public virtual List<ValueAnalisys> ValueAnalisys { get; set; }

}