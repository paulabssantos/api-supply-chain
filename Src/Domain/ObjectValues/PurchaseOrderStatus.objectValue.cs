using System.ComponentModel.DataAnnotations;

public class PurchaseOrderStatus{

    [Required(ErrorMessage = "Status do pedido de compra é obrigatório")]
    public int Status {get;set;}
    public string Justification {get;set;}
}   