using System.ComponentModel.DataAnnotations;

public interface CreatePurchaseOrderDto{
    [Required(ErrorMessage = "Id da análise de valor é obrigatório")]
    public int ValueAnalysisId {get;set;}

    [Required(ErrorMessage = "Status do pedido de compra é obrigatório")]
    [EnumDataType(typeof(PurchaseOrderStatusEnum),ErrorMessage = "Status do pedido de compra precisa ser 1(aprovado),2(reprovado) ou 3 (em análise)")]
    public PurchaseOrderStatusEnum Status {get;set;}
    public int Justification {get;set;} 
}