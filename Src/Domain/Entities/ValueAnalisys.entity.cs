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

    [Required(ErrorMessage = "Id da cotação é obrigatório")]

    public int QuotationId { get; set; }
    public virtual Quotation Quotation { get; set; }
    [Required(ErrorMessage = "Preço do produto é obrigatório")]
    public float Price { get; set; }
}