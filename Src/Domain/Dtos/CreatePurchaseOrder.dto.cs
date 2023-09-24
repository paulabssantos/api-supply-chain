using System.ComponentModel.DataAnnotations;

public class CreatePurchaseOrderDto{
    [Required(ErrorMessage = "Ids das análises de valor escolhidas são obrigatórios")]
    [MinLength(1, ErrorMessage = "É preciso de pelo menos um fornecedor escolhido para criar o pedido de compra")]
    public List<int> ValueAnalysisId {get;set;}

    [Required(ErrorMessage = "Status do pedido de compra é obrigatório")]
    [EnumDataType(typeof(PurchaseOrderStatusEnum),ErrorMessage = "Status do pedido de compra precisa ser 1(aprovado),2(reprovado) ou 3 (em análise)")]
    public PurchaseOrderStatusEnum Status {get;set;}
    public string? Justification {get;set;} 
}