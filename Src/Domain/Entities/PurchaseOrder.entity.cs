using System.ComponentModel.DataAnnotations;

public class PurchaseOrder
{
    [Key]
    public int Id {get;set;}
    [Required(ErrorMessage = "Dados do status do pedido de compras é obrigatório")]
    public virtual PurchaseOrderStatus PurchaseOrderStatus { get; set; }
    public virtual List<ValueAnalisys> ValueAnalisys { get; set; }

}