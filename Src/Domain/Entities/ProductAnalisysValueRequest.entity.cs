using System.ComponentModel.DataAnnotations;

public class ProductAnalisysValueRequest
{

    [Key]
    public int Id {get;set;}

    [Required(ErrorMessage = "Id do produto é obrigatório")]
    public int ProductId { get; set; }

    public virtual Product Product { get; set; }

    public int QuotationId {get;set;}
    public virtual Quotation Quotation {get;set;}

    [Required(ErrorMessage = "Quantidade do produto a ser analisado é obrigatória")]
    public int Quantity { get; set; }

    public virtual List<ValueAnalisys> ValueAnalisys {get;set;}
}