using System.ComponentModel.DataAnnotations;

public class Quotation
{

    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "Descrição da cotação é obrigatório")]

    public string Description { get; set; }

    [Required(ErrorMessage = "Tipo da cotação é obrigatório")]

    public string Type { get; set; }
    public virtual List<ProductAnalisysValueRequest> ProductAnalisysValueRequests { get; set; }
    public virtual List<QuotationFile> QuotationFile { get; set; }
}