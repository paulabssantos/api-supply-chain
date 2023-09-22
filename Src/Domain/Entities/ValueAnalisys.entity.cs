using System.ComponentModel.DataAnnotations;

public class ValueAnalisys
{
    [Key]
    public int Id { get; set; }
    [Required(ErrorMessage = "Id da solicitação de análise do produto é obrigatório")]
    public int ProductAnalisysValueRequestId { get; set; }
    public virtual ProductAnalisysValueRequest ProductAnalisysValueRequest { get; set; }

    [Required(ErrorMessage = "Id do fornecedor é obrigatório")]
    public int SupplierId { get; set; }

    public virtual Supplier Supplier { get; set; }
    public int PurchaseOrderId {get;set;}
    public virtual PurchaseOrder PurchaseOrder {get;set;}
    
    [Required(ErrorMessage = "Preço do produto é obrigatório")]
    public float Price { get; set; }
}